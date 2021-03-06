﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSDKv2
{
    /* RSDKv3 and RSDKv4 have nearly identical StageConfig file layouts, with RSDKv2 being very similar, 
    it just uses some of the unused bytes at the start of the file */
    public class StageConfig
    {

        public Palette palette = new Palette();
        public byte[] Unknown = new byte[97];

        public List<WAVConfiguration> WAVs = new List<WAVConfiguration>();

        public List<string> ObjectsNames = new List<string>();

        public StageConfig(string filename) : this(new Reader(filename))
        {

        }

        public StageConfig(System.IO.Stream stream) : this(new Reader(stream))
        {

        }

        public StageConfig(Reader reader)
        {
            palette.Read(reader, 2);

            reader.ReadByte(); //A byte comes just after the palette but it's use is unknown

            this.ReadObjectsNames(reader);

            this.ReadWAVConfiguration(reader);

            reader.Close();

        }

        internal void ReadObjectsNames(Reader reader)
        {
            byte objects_count = reader.ReadByte();

            for (int i = 0; i < objects_count; ++i)
            { ObjectsNames.Add(reader.ReadRSDKString()); }
        }

        internal void WriteObjectsNames(Writer writer)
        {
            writer.Write((byte)ObjectsNames.Count);
            foreach (string name in ObjectsNames)
                writer.WriteRSDKString(name);
        }

        internal void ReadWAVConfiguration(Reader reader)
        {
            byte wavs_count = reader.ReadByte();

            for (int i = 0; i < wavs_count; ++i)
            { WAVs.Add(new WAVConfiguration(reader)); }
        }

        internal void WriteWAVConfiguration(Writer writer)
        {
            writer.Write((byte)WAVs.Count);
            foreach (WAVConfiguration wav in WAVs)
                wav.Write(writer);
        }

        public void Write(string filename)
        {
            using (Writer writer = new Writer(filename))
                this.Write(writer);
        }

        public void Write(System.IO.Stream stream)
        {
            using (Writer writer = new Writer(stream))
                this.Write(writer);
        }

        internal void Write(Writer writer)
        {
            palette.Write(writer);

            writer.Write(0);

            WriteObjectsNames(writer);

            WriteWAVConfiguration(writer);

            writer.Close();
        }

    }
}
