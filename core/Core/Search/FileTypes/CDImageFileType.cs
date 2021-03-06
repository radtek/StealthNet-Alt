//RShare
//Copyright (C) 2009 T.Norad

//This program is free software; you can redistribute it and/or
//modify it under the terms of the GNU General Public License
//as published by the Free Software Foundation; either version 2
//of the License, or (at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

using System;
using System.Collections.Generic;
using System.Text;

namespace Regensburger.RShare
{
    /**
     * This class defines the file extentions for this file type category 
     */
    public class CDImageFileType : FileType
    {
        public CDImageFileType()
        {
            FileExtentions = new string[] { ".bin", ".bwa", ".bwi", ".bws", ".bwt", ".ccd", ".cue", ".dmg", ".dmz", ".img", ".iso", ".mdf", ".mds", ".nrg", ".sub", ".toast"};
        }

        public override string ToString()
        {
            string fileTypeString;
            switch (Settings.Instance["UICulture"])
            {
                case "en":
                    fileTypeString = "CD-Image";
                    break;

                case "de":
                    fileTypeString = "CD-Images";
                    break;

                case "fr":
                    fileTypeString = "Images CD";
                    break;

                case "it":
                    fileTypeString = "Immagini CD";
                    break;

                case "tr":
                    fileTypeString = "CD-Imajı";
                    break;

                default:
                    fileTypeString = "CD-Image";
                    break;
            }
            return fileTypeString;
        }
    }
}
