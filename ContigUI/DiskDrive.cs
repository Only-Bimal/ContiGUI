using System;
using System.Collections.Generic;
using System.Management;

namespace ContigUI
{
	public class Disk
	{
		public string DeviceId { get; private set; }
		public string SerialNumber { get; private set; }
		public BusType BusType { get; private set; }
		public string Name { get; private set; }
		public string Model { get; private set; }
		public string Size { get; private set; }
		public MediaType DiskType { get; private set; }


		public static IEnumerable<Disk> GetDisks()
		{
			// Return List 
			var disks = new List<Disk>();

			// Specify Windows Storage Management API namespace.
			var scope = new ManagementScope(@"\\.\root\microsoft\windows\storage");
			scope.Connect();

			var searcher = new ManagementObjectSearcher("SELECT * FROM MSFT_PhysicalDisk") { Scope = scope };

			foreach (var disk in searcher.Get())
			{
				var physicalDisk = new Disk
				{
					DeviceId = disk["DeviceId"].ToString(),
					SerialNumber = disk["SerialNumber"].ToString(),
					Name = disk["FriendlyName"].ToString(),
					Model = disk["Model"].ToString(),
					Size = SizeFormatter.FormatSize(Int64.TryParse(disk["Size"].ToString(), out Int64 temp) ? temp : 0),
					DiskType = Enum.TryParse(disk["MediaType"].ToString(), out MediaType tempMediaType) ? tempMediaType : MediaType.Unspecified,
					BusType = Enum.TryParse(disk["BusType"].ToString(), out BusType temBusType) ? temBusType : ContigUI.BusType.Unknown
				};

				disks.Add(physicalDisk);
			}

			return disks;
		}
	}
	public class Drive
	{
		public string DriveLetter { get; set; }
		public string DriveLabel { get; set; }
		public MediaType DriveType { get; set; }
		public string DriveSize { get; set; }

		public static IEnumerable<Drive> GetDrives(IEnumerable<Disk> disks = null)
		{
			// Get all the disks if not specified already
			if (disks == null) { disks = Disk.GetDisks(); }
			var allDrives = new List<Drive>();
			foreach (var disk in disks)
			{
				var drives = GetDrives(disk);
				allDrives.AddRange(drives);
			}

			return allDrives;
		}

		public static IEnumerable<Drive> GetDrives(Disk disk)
		{
			if (disk == null) { throw new ArgumentNullException(nameof(disk)); }
			if (string.IsNullOrWhiteSpace(disk.SerialNumber)) { throw new ArgumentOutOfRangeException(nameof(disk), disk.SerialNumber, "Serial number is missing on the disk."); }

			var drives = new List<Drive>();
			var diskSearcher = new ManagementClass(@"Win32_Diskdrive");

			var disks = diskSearcher.GetInstances();
			foreach (var diskItemTemp in disks)
			{
				var diskItem = (ManagementObject)diskItemTemp;
				var serialNumber = (string)diskItem["SerialNumber"];

				if (!string.Equals(serialNumber, disk.SerialNumber, StringComparison.OrdinalIgnoreCase)) { continue; }

				foreach (var partitionTemp in diskItem.GetRelated("Win32_DiskPartition"))
				{
					var partition = (ManagementObject)partitionTemp;
					foreach (var driveItem in partition.GetRelated("Win32_LogicalDisk"))
					{
						var drive = new Drive
						{
							DriveLetter = driveItem["Name"].ToString(),
							DriveLabel = driveItem["VolumeName"].ToString(),
							DriveType = disk.DiskType,
							DriveSize = SizeFormatter.FormatSize(Int64.TryParse(driveItem["Size"].ToString(), out Int64 temp) ? temp : 0)
						};

						drives.Add(drive);
					}
				}
			}

			return drives;
		}
	}

	public enum MediaType
	{
		Unspecified,
		HDD = 3,
		SSD = 4
	}

	public enum BusType
	{
		Unknown = 0,
		SCSI = 1,
		ATAPI = 2,
		ATA = 3,
		Bus1394 = 4,
		SSA = 5,
		FibreChannel = 6,
		USB = 7,
		RAID = 8,
		iSCSI = 9,
		SAS = 10,
		SATA = 11,
		SD = 12,
		MMC = 13,
		Virtual = 14,
		FileBackedVirtual = 15,
		StorageSpaces = 16,
		NVMe = 17,
		SCM = 18,
		UFS = 19,
		MicrosoftReserved = 20

	}


	public static class SizeFormatter
	{
		// Load all suffixes in an array  
		private static readonly string[] Suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB" };

		public static string FormatSize(long bytes)
		{
			var counter = 0;
			var number = (decimal)bytes;
			while (Math.Round(number / 1024) >= 1)
			{
				number /= 1024;
				counter++;
			}
			return $"{number:n1} {Suffixes[counter]}";
		}
	}
}