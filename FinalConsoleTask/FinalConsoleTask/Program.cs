﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace FinalConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemFileReader.Read read = new SystemFileReader.Read();
            Thread[] ThreadArray = new Thread[3];
            try
            {
                for (var i = 0; i < ThreadArray.Length; i++)

                {

                    ThreadArray[i] = new Thread(read.Path);

                    ThreadArray[i].Start();

                    ThreadArray[i].Name = (i + 1).ToString();


                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }



        }
        //void PrintFileSystemEntries(string path)
        //{

        //    try
        //    {
        //        // Obtain the file system entries in the directory path.
        //        string[] directoryEntries =
        //            System.IO.Directory.GetFileSystemEntries(path);

        //        foreach (string str in directoryEntries)
        //        {
        //            System.Console.WriteLine(str);
        //        }
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        System.Console.WriteLine("Path is a null reference.");
        //    }
        //    catch (System.Security.SecurityException)
        //    {
        //        System.Console.WriteLine("The caller does not have the " +
        //            "required permission.");
        //    }
        //    catch (ArgumentException)
        //    {
        //        System.Console.WriteLine("Path is an empty string, " +
        //            "contains only white spaces, " +
        //            "or contains invalid characters.");
        //    }
        //    catch (System.IO.DirectoryNotFoundException)
        //    {
        //        System.Console.WriteLine("The path encapsulated in the " +
        //            "Directory object does not exist.");
        //    }
        //}
        //void PrintFileSystemEntries(string path, string pattern)
        //{
        //    try
        //    {
        //        // Obtain the file system entries in the directory
        //        // path that match the pattern.
        //        string[] directoryEntries =
        //            System.IO.Directory.GetFileSystemEntries(path, pattern);

        //        foreach (string str in directoryEntries)
        //        {
        //            System.Console.WriteLine(str);
        //        }
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        System.Console.WriteLine("Path is a null reference.");
        //    }
        //    catch (System.Security.SecurityException)
        //    {
        //        System.Console.WriteLine("The caller does not have the " +
        //            "required permission.");
        //    }
        //    catch (ArgumentException)
        //    {
        //        System.Console.WriteLine("Path is an empty string, " +
        //            "contains only white spaces, " +
        //            "or contains invalid characters.");
        //    }
        //    catch (System.IO.DirectoryNotFoundException)
        //    {
        //        System.Console.WriteLine("The path encapsulated in the " +
        //            "Directory object does not exist.");
        //    }
        //}

        //// Print out all logical drives on the system.
        //void GetLogicalDrives()
        //{
        //    try
        //    {
        //        string[] drives = System.IO.Directory.GetLogicalDrives();

        //        foreach (string str in drives)
        //        {
        //            System.Console.WriteLine(str);
        //        }
        //    }
        //    catch (System.IO.IOException)
        //    {
        //        System.Console.WriteLine("An I/O error occurs.");
        //    }
        //    catch (System.Security.SecurityException)
        //    {
        //        System.Console.WriteLine("The caller does not have the " +
        //            "required permission.");
        //    }
        //}
        //void GetParent(string path)
        //{
        //    try
        //    {
        //        System.IO.DirectoryInfo directoryInfo =
        //            System.IO.Directory.GetParent(path);

        //        System.Console.WriteLine(directoryInfo.FullName);
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        System.Console.WriteLine("Path is a null reference.");
        //    }
        //    catch (ArgumentException)
        //    {
        //        System.Console.WriteLine("Path is an empty string, " +
        //            "contains only white spaces, or " +
        //            "contains invalid characters.");
        //    }
        //}
        //void Move(string sourcePath, string destinationPath)
        //{
        //    try
        //    {
        //        System.IO.Directory.Move(sourcePath, destinationPath);
        //        System.Console.WriteLine("The directory move is complete.");
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        System.Console.WriteLine("Path is a null reference.");
        //    }
        //    catch (System.Security.SecurityException)
        //    {
        //        System.Console.WriteLine("The caller does not have the " +
        //            "required permission.");
        //    }
        //    catch (ArgumentException)
        //    {
        //        System.Console.WriteLine("Path is an empty string, " +
        //            "contains only white spaces, " +
        //            "or contains invalid characters.");
        //    }
        //    catch (System.IO.IOException)
        //    {
        //        System.Console.WriteLine("An attempt was made to move a " +
        //            "directory to a different " +
        //            "volume, or destDirName " +
        //            "already exists.");
        //    }
        //}
    }
}

