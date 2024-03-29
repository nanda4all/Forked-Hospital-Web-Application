﻿using EMEHospitalWebApp.Data;

namespace EMEHospitalWebApp.Domain {
    public abstract class UniqueEntity {
        public static string DefaultSrt => "Undefined";
        public static DateTime DefaultDate => DateTime.MinValue;
        protected static string getValue(string? v) => v ?? DefaultSrt;
        protected static IsoGender getValue(IsoGender? v) => v ?? IsoGender.NotApplicable;
        protected static DateTime getValue(DateTime? v) => v ?? DefaultDate;
        public abstract string Id { get; }
        public abstract byte[] Token { get; }
    }
    public abstract class UniqueEntity<TData> : UniqueEntity where TData : UniqueData, new() {
        public TData Data { get; }
        protected UniqueEntity(TData d) => Data = d;
        public override string Id => getValue(Data?.Id);
        public override byte[] Token => Data?.Token ?? Array.Empty<byte>();
    }
}
