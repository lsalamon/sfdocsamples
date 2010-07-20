﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fwk.Caching;
using System.Net;


namespace FwkFtpClient
{
    public  static class FtpUtil
    {
        public static FwkSimpleStorageBase<JabberClient> storage = new FwkSimpleStorageBase<JabberClient>();
        const string CRLF = "\r\n";
        internal static string Eater(string line, int ix, int n)
        {
            string res = "";
            int ws = 0;
            for (int i = 1; i < line.Length; i++)
            {
                if ((line[i] == ' ') && (line[i - 1] != ' '))
                {
                    ws = ws + 1;
                }
                if ((ws >= ix) && (ws < (ix + n)))
                {
                    res = res + line[i];
                }
            }
            return res.Trim();
        }

        internal static void Parse(string line)
        {
            string protection = Eater(line, 0, 1);
            string owner = Eater(line, 1, 3);
            int size = int.Parse(Eater(line, 4, 1));
            string tim = Eater(line, 5, 3);
            string filename = Eater(line, 8, 100);
            //Console.WriteLine(filename + " " + size + " " + tim);
        }

        static ServerFileData ParseDosDirLine(string line)
        {
            ServerFileData sfd = new ServerFileData();


            try
            {
                string[] parsed = new string[3];
                int index = 0;
                int position = 0;

                // Parse out the elements
                position = line.IndexOf(' ');
                while (index < parsed.Length)
                {
                    parsed[index] = line.Substring(0, position);
                    line = line.Substring(position);
                    line = line.Trim();
                    index++;
                    position = line.IndexOf(' ');
                }
                sfd.FileName = line;

                if (parsed[2] != "<DIR>")
                    sfd.Size = Convert.ToInt32(parsed[2]);

                sfd.Date = parsed[0] + ' ' + parsed[1];
                sfd.IsDirectory = parsed[2] == "<DIR>";
            }
            catch
            {
                sfd = null;
            }
            return sfd;
        }


        static ServerFileData ParseUnixDirLine(string line)
        {
            ServerFileData sfd = new ServerFileData();

            try
            {
                string[] parsed = new string[8];
                int index = 0;
                int position;

                // Parse out the elements
                position = line.IndexOf(' ');
                while (index < parsed.Length)
                {
                    parsed[index] = line.Substring(0, position);
                    line = line.Substring(position);
                    line = line.Trim();
                    index++;
                    position = line.IndexOf(' ');
                }
                sfd.FileName = line;

                sfd.Permission = parsed[0];
                sfd.Owner = parsed[2];
                sfd.Group = parsed[3];
                sfd.Size = Convert.ToInt32(parsed[4]);
                sfd.Date = parsed[5] + ' ' + parsed[6] + ' ' + parsed[7];
                sfd.IsDirectory = sfd.Permission[0] == 'd';
            }
            catch
            {
                sfd = null;
            }
            return sfd;
        }

        /// <summary>
        /// Convierte una linea retornada atraves del comando FTP LIST a un objeto tipificado.-
        /// Ejemplo: linea proveniente de un server Unix
        /// -rwxrwxr--   1 andrw    video     3621773 Jan 31  2003 2FOR GOOD - You And Me.MP3
        /// </summary>
        /// <param name="sDir"></param>
        internal static ServerFileData ParseUnixDirList(string fileLine)
        {

            try
            {

                fileLine = fileLine.Replace("\r", string.Empty);
     
                //string[] sFile = sDir.Split(new Char[] { '\r' });
                ServerFileData sfd = null;
                int autodetect = 0;

                //foreach (string fileLine in sDir)
                //{
                    if (autodetect == 0)
                    {
                        sfd = ParseDosDirLine(fileLine);
                        if (sfd == null)
                        {
                            sfd = ParseUnixDirLine(fileLine);
                            autodetect = 2;
                        }
                        else
                            autodetect = 1;
                    }
                    else
                        if (autodetect == 1)
                            sfd = ParseDosDirLine(fileLine);
                        else
                            if (autodetect == 2)
                                sfd = ParseUnixDirLine(fileLine);


                //}
                return sfd;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
    }


    public class ServerFileData
    {
        private bool isDirectory;

        public bool IsDirectory
        {
            get { return isDirectory; }
            set { isDirectory = value; }
        }
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private string permission;

        public string Permission
        {
            get { return permission; }
            set { permission = value; }
        }
        private string owner;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        private string group;

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public ServerFileData()
        {
        }
    }





    [Serializable]
    public class JabberClient
    {
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        string _Server;

        public string Server
        {
            get { return _Server; }
            set { _Server = value; }
        }
        string _Port;

        public string Port
        {
            get { return _Port; }
            set { _Port = value; }
        }

        

    }
}
