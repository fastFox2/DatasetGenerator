﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;

namespace DatasetGenerator
{
    class DataItem
    {
        public string Label { get; set; }
        public BitmapImage Image { get; set; }
        public string ImageSourceFileName { get; set; }
    }
}
