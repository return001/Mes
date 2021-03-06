﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BE.Objects
{
    [Serializable]
    public struct SearchOrderDetailArgs
    {
        public string OrderBy;
        public int? RowNumberFrom;
        public int? RowNumberTo;

        
        public string OrderNo;
        public string Barcode;
        public List<Guid> CabinetIDs;
        public List<string> CabinetNums;
        public string MaterialType;
        public List<string> ItemNames;        
        public List<Guid> OrderIDs;
        public string ItemType;
        public string PackageSizeType;
        public string PackageCategory;
        public string BattchNum;
        public string BattchCode;
        public string OrderStatus;
        public bool? IsStandard;
        public bool? IsOutsourcing;
        public string CabinetCode;
        public string OutOrderNo;
        public string ItemCategory;
        public bool? IsSpecialShap;
        public List<string> RemoveItems;
        public int? MadeWidthFrom;
        public int? MadeWidthTo;
        public int? MadeLengthFrom;
        public int? MadeLengthTo;
        public string CabinetStatus;
        public int? MadeMinSize;
        public int? MadeMaxSize;

    }
}
