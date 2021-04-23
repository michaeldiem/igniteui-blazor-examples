﻿using System;
using System.Collections.Generic; 

namespace Infragistics.Samples
{  
    public class CountryInfo
    { 
        public double Pop { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
    }

    public static class CountryTreeData
    {
        public static List<CountryInfo> Create()
        {
            var data = new List<CountryInfo>
            {
                // creating parents for tree data
                new CountryInfo { Parent = null, Name = "Asia", Pop = double.NaN,  },
                new CountryInfo { Parent = null, Name = "Middle East", Pop = double.NaN,  },
                new CountryInfo { Parent = null, Name = "Europe", Pop = double.NaN,  },
                new CountryInfo { Parent = null, Name = "North America", Pop = double.NaN, },
                new CountryInfo { Parent = null, Name = "Central America", Pop = double.NaN, },
                new CountryInfo { Parent = null, Name = "South America", Pop = double.NaN,  },
                new CountryInfo { Parent = null, Name = "Africa", Pop = double.NaN,  },
                new CountryInfo { Parent = null, Name = "Oceania", Pop = double.NaN,  },
                // creating children of tree data
                new CountryInfo { Parent = "Africa", Name = "Angola", Pop = 19618432 },
                new CountryInfo { Parent = "Africa", Name = "Benin", Pop = 9099922 },
                new CountryInfo { Parent = "Africa", Name = "Botswana", Pop = 2030738 },
                new CountryInfo { Parent = "Africa", Name = "Burkina Faso", Pop = 16967845 },
                new CountryInfo { Parent = "Africa", Name = "Burundi", Pop = 8575172 },
                new CountryInfo { Parent = "Africa", Name = "Cameroon", Pop = 20030362 },
                new CountryInfo { Parent = "Africa", Name = "Cape Verde", Pop = 500585 },
                new CountryInfo { Parent = "Africa", Name = "Central African Republic", Pop = 4486837 },
                new CountryInfo { Parent = "Africa", Name = "Chad", Pop = 11525496 },
                new CountryInfo { Parent = "Africa", Name = "Comoros", Pop = 753943 },
                new CountryInfo { Parent = "Africa", Name = "Cote Ivoire", Pop = 20152894 },
                new CountryInfo { Parent = "Africa", Name = "Djibouti", Pop = 905564 },
                new CountryInfo { Parent = "Africa", Name = "Equatorial Guinea", Pop = 720213 },
                new CountryInfo { Parent = "Africa", Name = "Eritrea", Pop = 5415280 },
                new CountryInfo { Parent = "Africa", Name = "Ethiopia", Pop = 84734262 },
                new CountryInfo { Parent = "Africa", Name = "Gabon", Pop = 1534262 },
                new CountryInfo { Parent = "Africa", Name = "Gambia", Pop = 1776103 },
                new CountryInfo { Parent = "Africa", Name = "Ghana", Pop = 24965816 },
                new CountryInfo { Parent = "Africa", Name = "Guinea", Pop = 10221808 },
                new CountryInfo { Parent = "Africa", Name = "Guinea-Bissau", Pop = 1547061 },
                new CountryInfo { Parent = "Africa", Name = "Kenya", Pop = 41609728 },
                new CountryInfo { Parent = "Africa", Name = "Lesotho", Pop = 2193843 },
                new CountryInfo { Parent = "Africa", Name = "Liberia", Pop = 4128572 },
                new CountryInfo { Parent = "Africa", Name = "Madagascar", Pop = 21315135 },
                new CountryInfo { Parent = "Africa", Name = "Malawi", Pop = 15380888 },
                new CountryInfo { Parent = "Africa", Name = "Mali", Pop = 15839538 },
                new CountryInfo { Parent = "Africa", Name = "Mauritania", Pop = 3541540 },
                new CountryInfo { Parent = "Africa", Name = "Mauritius", Pop = 1286051 },
                new CountryInfo { Parent = "Africa", Name = "Mozambique", Pop = 23929708 },
                new CountryInfo { Parent = "Africa", Name = "Namibia", Pop = 2324004 },
                new CountryInfo { Parent = "Africa", Name = "Niger", Pop = 16068994 },
                new CountryInfo { Parent = "Africa", Name = "Nigeria", Pop = 162470737 },
                new CountryInfo { Parent = "Africa", Name = "Rwanda", Pop = 10942950 },
                new CountryInfo { Parent = "Africa", Name = "Sao Tome and Principe", Pop = 168526 },
                new CountryInfo { Parent = "Africa", Name = "Senegal", Pop = 12767556 },
                new CountryInfo { Parent = "Africa", Name = "Seychelles", Pop = 86000 },
                new CountryInfo { Parent = "Africa", Name = "Sierra Leone", Pop = 5997486 },
                new CountryInfo { Parent = "Africa", Name = "South Africa", Pop = 50586757 },
                new CountryInfo { Parent = "Africa", Name = "South Sudan", Pop = 10314021 },
                new CountryInfo { Parent = "Africa", Name = "Sudan", Pop = 34318385 },
                new CountryInfo { Parent = "Africa", Name = "Swaziland", Pop = 1067773 },
                new CountryInfo { Parent = "Africa", Name = "Tanzania", Pop = 46218486 },
                new CountryInfo { Parent = "Africa", Name = "Togo", Pop = 6154813 },
                new CountryInfo { Parent = "Africa", Name = "Uganda", Pop = 34509205 },
                new CountryInfo { Parent = "Africa", Name = "Zambia", Pop = 13474959 },
                new CountryInfo { Parent = "Africa", Name = "Zimbabwe", Pop = 12754378 } ,
                new CountryInfo { Parent = "Africa", Name = "Congo", Pop = 4139748 },
                new CountryInfo { Parent = "Africa", Name = "Congo, Dem. Rep.", Pop = 67757577 },
                new CountryInfo { Parent = "Asia", Name = "Bangladesh", Pop = 150493658 },
                new CountryInfo { Parent = "Asia", Name = "Bhutan", Pop = 738267 },
                new CountryInfo { Parent = "Asia", Name = "Brunei", Pop = 405938 },
                new CountryInfo { Parent = "Asia", Name = "Cambodia", Pop = 14305183 },
                new CountryInfo { Parent = "Asia", Name = "China", Pop = 1344130000 },
                new CountryInfo { Parent = "Asia", Name = "India", Pop = 1241491960 },
                new CountryInfo { Parent = "Asia", Name = "Indonesia", Pop = 242325638 },
                new CountryInfo { Parent = "Asia", Name = "Japan", Pop = 127817277 },
                new CountryInfo { Parent = "Asia", Name = "Kazakhstan", Pop = 16558676 },
                new CountryInfo { Parent = "Asia", Name = "Kyrgyz Republic", Pop = 5514600 },
                new CountryInfo { Parent = "Asia", Name = "Noth Korea", Pop = 24451285 },
                new CountryInfo { Parent = "Asia", Name = "South Korea", Pop = 49779000 },
                new CountryInfo { Parent = "Asia", Name = "Macao", Pop = 555731 },
                new CountryInfo { Parent = "Asia", Name = "Hong Kong", Pop = 7071600 },
                new CountryInfo { Parent = "Asia", Name = "Lao PDR", Pop = 6288037 },
                new CountryInfo { Parent = "Asia", Name = "Malaysia", Pop = 28859154 },
                new CountryInfo { Parent = "Asia", Name = "Maldives", Pop = 320081 },
                new CountryInfo { Parent = "Asia", Name = "Mongolia", Pop = 2800114 },
                new CountryInfo { Parent = "Asia", Name = "Myanmar", Pop = 48336763 },
                new CountryInfo { Parent = "Asia", Name = "Nepal", Pop = 30485798 },
                new CountryInfo { Parent = "Asia", Name = "Philippines", Pop = 94852030 },
                new CountryInfo { Parent = "Asia", Name = "Singapore", Pop = 5183700 },
                new CountryInfo { Parent = "Asia", Name = "Sri Lanka", Pop = 20869000 },
                new CountryInfo { Parent = "Asia", Name = "Tajikistan", Pop = 6976958 },
                new CountryInfo { Parent = "Asia", Name = "Thailand", Pop = 69518555 },
                new CountryInfo { Parent = "Asia", Name = "Turkmenistan", Pop = 5105301 },
                new CountryInfo { Parent = "Asia", Name = "Uzbekistan", Pop = 29341200 },
                new CountryInfo { Parent = "Asia", Name = "Vietnam", Pop = 87840000 },
                new CountryInfo { Parent = "Central America", Name = "Antigua and Barbuda", Pop = 89612 },
                new CountryInfo { Parent = "Central America", Name = "Aruba", Pop = 108141 },
                new CountryInfo { Parent = "Central America", Name = "Bahamas", Pop = 347176 },
                new CountryInfo { Parent = "Central America", Name = "Barbados", Pop = 273925 },
                new CountryInfo { Parent = "Central America", Name = "Belize", Pop = 356600 },
                new CountryInfo { Parent = "Central America", Name = "Bermuda", Pop = 64700 },
                new CountryInfo { Parent = "Central America", Name = "Cayman Islands", Pop = 56729 },
                new CountryInfo { Parent = "Central America", Name = "Costa Rica", Pop = 4726575 },
                new CountryInfo { Parent = "Central America", Name = "Cuba", Pop = 11253665 },
                new CountryInfo { Parent = "Central America", Name = "Curacao", Pop = 145619 },
                new CountryInfo { Parent = "Central America", Name = "Dominica", Pop = 67675 },
                new CountryInfo { Parent = "Central America", Name = "Dominican Republic", Pop = 10056181 },
                new CountryInfo { Parent = "Central America", Name = "Faeroe Islands", Pop = 48863 },
                new CountryInfo { Parent = "Central America", Name = "Grenada", Pop = 104890 },
                new CountryInfo { Parent = "Central America", Name = "Guam", Pop = 182111 },
                new CountryInfo { Parent = "Central America", Name = "Guatemala", Pop = 14757316 },
                new CountryInfo { Parent = "Central America", Name = "Haiti", Pop = 10123787 },
                new CountryInfo { Parent = "Central America", Name = "Honduras", Pop = 7754687 },
                new CountryInfo { Parent = "Central America", Name = "Jamaica", Pop = 2706500 },
                new CountryInfo { Parent = "Central America", Name = "Nicaragua", Pop = 5869859 },
                new CountryInfo { Parent = "Central America", Name = "Northern Mariana Islands", Pop = 61174 },
                new CountryInfo { Parent = "Central America", Name = "Panama", Pop = 3571185 },
                new CountryInfo { Parent = "Central America", Name = "St. Kitts and Nevis", Pop = 53051 },
                new CountryInfo { Parent = "Central America", Name = "St. Lucia", Pop = 176000 },
                new CountryInfo { Parent = "Central America", Name = "St. Vincent and the Grenadines", Pop = 109365 },
                new CountryInfo { Parent = "Central America", Name = "Trinidad and Tobago", Pop = 1346350 },
                new CountryInfo { Parent = "Central America", Name = "Turks and Caicos Islands", Pop = 39184 },
                new CountryInfo { Parent = "Central America", Name = "Virgin Islands (U.S.)", Pop = 109666 },
                new CountryInfo { Parent = "Central America", Name = "El Salvador", Pop = 6227491 },
                new CountryInfo { Parent = "Central America", Name = "Puerto Rico", Pop = 3706690 },
                new CountryInfo { Parent = "Europe", Name = "Albania", Pop = 3215988 },
                new CountryInfo { Parent = "Europe", Name = "Andorra", Pop = 86165 },
                new CountryInfo { Parent = "Europe", Name = "Armenia", Pop = 3100236 },
                new CountryInfo { Parent = "Europe", Name = "Austria", Pop = 8423635 },
                new CountryInfo { Parent = "Europe", Name = "Belarus", Pop = 9473000 },
                new CountryInfo { Parent = "Europe", Name = "Belgium", Pop = 11020952 },
                new CountryInfo { Parent = "Europe", Name = "Bosnia and Herzegovina", Pop = 3752228 },
                new CountryInfo { Parent = "Europe", Name = "Bulgaria", Pop = 7348328 },
                new CountryInfo { Parent = "Europe", Name = "Channel Islands", Pop = 153876 },
                new CountryInfo { Parent = "Europe", Name = "Croatia", Pop = 4403000 },
                new CountryInfo { Parent = "Europe", Name = "Cyprus", Pop = 1116564 },
                new CountryInfo { Parent = "Europe", Name = "Czech Republic", Pop = 10496088 },
                new CountryInfo { Parent = "Europe", Name = "Denmark", Pop = 5570572 },
                new CountryInfo { Parent = "Europe", Name = "Estonia", Pop = 1339928 },
                new CountryInfo { Parent = "Europe", Name = "Finland", Pop = 5388272 },
                new CountryInfo { Parent = "Europe", Name = "France", Pop = 65433714 },
                new CountryInfo { Parent = "Europe", Name = "Georgia", Pop = 4486000 },
                new CountryInfo { Parent = "Europe", Name = "Germany", Pop = 81797673 },
                new CountryInfo { Parent = "Europe", Name = "Greece", Pop = 11300410 },
                new CountryInfo { Parent = "Europe", Name = "Hungary", Pop = 9971727 },
                new CountryInfo { Parent = "Europe", Name = "Iceland", Pop = 319014 },
                new CountryInfo { Parent = "Europe", Name = "Ireland", Pop = 4576317 },
                new CountryInfo { Parent = "Europe", Name = "Isle of Man", Pop = 83327 },
                new CountryInfo { Parent = "Europe", Name = "Italy", Pop = 60723603 },
                new CountryInfo { Parent = "Europe", Name = "Kosovo", Pop = 1802765 },
                new CountryInfo { Parent = "Europe", Name = "Latvia", Pop = 2058184 },
                new CountryInfo { Parent = "Europe", Name = "Liechtenstein", Pop = 36304 },
                new CountryInfo { Parent = "Europe", Name = "Lithuania", Pop = 3030173 },
                new CountryInfo { Parent = "Europe", Name = "Luxembourg", Pop = 518252 },
                new CountryInfo { Parent = "Europe", Name = "Malta", Pop = 415654 },
                new CountryInfo { Parent = "Europe", Name = "Moldova", Pop = 3559000 },
                new CountryInfo { Parent = "Europe", Name = "Monaco", Pop = 35427 },
                new CountryInfo { Parent = "Europe", Name = "Montenegro", Pop = 632261 },
                new CountryInfo { Parent = "Europe", Name = "Netherlands", Pop = 16693074 },
                new CountryInfo { Parent = "Europe", Name = "Norway", Pop = 4953088 },
                new CountryInfo { Parent = "Europe", Name = "Poland", Pop = 38534157 },
                new CountryInfo { Parent = "Europe", Name = "Portugal", Pop = 10556999 },
                new CountryInfo { Parent = "Europe", Name = "Romania", Pop = 21384832 },
                new CountryInfo { Parent = "Europe", Name = "Russian", Pop = 142960000 },
                new CountryInfo { Parent = "Europe", Name = "San Marino", Pop = 31735 },
                new CountryInfo { Parent = "Europe", Name = "Serbia", Pop = 7258745 },
                new CountryInfo { Parent = "Europe", Name = "Sint Maarten", Pop = 36609 },
                new CountryInfo { Parent = "Europe", Name = "Slovak Republic", Pop = 5398384 },
                new CountryInfo { Parent = "Europe", Name = "Slovenia", Pop = 2052843 },
                new CountryInfo { Parent = "Europe", Name = "Spain", Pop = 46174601 },
                new CountryInfo { Parent = "Europe", Name = "St. Martin (French part)", Pop = 30615 },
                new CountryInfo { Parent = "Europe", Name = "Sweden", Pop = 9449213 },
                new CountryInfo { Parent = "Europe", Name = "Switzerland", Pop = 7912398 },
                new CountryInfo { Parent = "Europe", Name = "Ukraine", Pop = 45706100 },
                new CountryInfo { Parent = "Europe", Name = "United Kingdom", Pop = 62744081 },
                new CountryInfo { Parent = "Europe", Name = "Macedonia, FYR", Pop = 2063893 },
                new CountryInfo { Parent = "Middle East", Name = "Afghanistan", Pop = 35320445 },
                new CountryInfo { Parent = "Middle East", Name = "Algeria", Pop = 35980193 },
                new CountryInfo { Parent = "Middle East", Name = "Azerbaijan", Pop = 9173082 },
                new CountryInfo { Parent = "Middle East", Name = "Bahrain", Pop = 1323535 },
                new CountryInfo { Parent = "Middle East", Name = "Iraq", Pop = 32961959 },
                new CountryInfo { Parent = "Middle East", Name = "Israel", Pop = 7765900 },
                new CountryInfo { Parent = "Middle East", Name = "Jordan", Pop = 6181000 },
                new CountryInfo { Parent = "Middle East", Name = "Kuwait", Pop = 2818042 },
                new CountryInfo { Parent = "Middle East", Name = "Lebanon", Pop = 4259405 },
                new CountryInfo { Parent = "Middle East", Name = "Libya", Pop = 6422772 },
                new CountryInfo { Parent = "Middle East", Name = "Morocco", Pop = 32272974 },
                new CountryInfo { Parent = "Middle East", Name = "Oman", Pop = 2846145 },
                new CountryInfo { Parent = "Middle East", Name = "Pakistan", Pop = 176745364 },
                new CountryInfo { Parent = "Middle East", Name = "Qatar", Pop = 1870041 },
                new CountryInfo { Parent = "Middle East", Name = "Saudi Arabia", Pop = 28082541 },
                new CountryInfo { Parent = "Middle East", Name = "Somalia", Pop = 9556873 },
                new CountryInfo { Parent = "Middle East", Name = "Syrian Arab Republic", Pop = 20820311 },
                new CountryInfo { Parent = "Middle East", Name = "Tunisia", Pop = 10673800 },
                new CountryInfo { Parent = "Middle East", Name = "Turkey", Pop = 73639596 },
                new CountryInfo { Parent = "Middle East", Name = "United Arab Emirates", Pop = 7890924 },
                new CountryInfo { Parent = "Middle East", Name = "West Bank and Gaza", Pop = 3927051 },
                new CountryInfo { Parent = "Middle East", Name = "Yemen", Pop = 24799880 },
                new CountryInfo { Parent = "Middle East", Name = "Iran", Pop = 74798599 },
                new CountryInfo { Parent = "Middle East", Name = "Egypt.", Pop = 82536770 },
                new CountryInfo { Parent = "North America", Name = "Canada", Pop = 34483975 },
                new CountryInfo { Parent = "North America", Name = "Greenland", Pop = 56840 },
                new CountryInfo { Parent = "North America", Name = "Mexico", Pop = 114793341 },
                new CountryInfo { Parent = "North America", Name = "United States", Pop = 311591917 },
                new CountryInfo { Parent = "Oceania", Name = "American Samoa", Pop = 69543 },
                new CountryInfo { Parent = "Oceania", Name = "Australia", Pop = 22323900 },
                new CountryInfo { Parent = "Oceania", Name = "Fiji", Pop = 868406 },
                new CountryInfo { Parent = "Oceania", Name = "French Polynesia", Pop = 273777 },
                new CountryInfo { Parent = "Oceania", Name = "Kiribati", Pop = 101093 },
                new CountryInfo { Parent = "Oceania", Name = "Marshall Islands", Pop = 54816 },
                new CountryInfo { Parent = "Oceania", Name = "New Caledonia", Pop = 254024 },
                new CountryInfo { Parent = "Oceania", Name = "New Zealand", Pop = 4405200 },
                new CountryInfo { Parent = "Oceania", Name = "Palau", Pop = 20609 },
                new CountryInfo { Parent = "Oceania", Name = "Papua New Guinea", Pop = 7013829 },
                new CountryInfo { Parent = "Oceania", Name = "Samoa", Pop = 183874 },
                new CountryInfo { Parent = "Oceania", Name = "Timor-Leste", Pop = 1175880 },
                new CountryInfo { Parent = "Oceania", Name = "Tonga", Pop = 104509 },
                new CountryInfo { Parent = "Oceania", Name = "Tuvalu", Pop = 9847 },
                new CountryInfo { Parent = "Oceania", Name = "Vanuatu", Pop = 245619 },
                new CountryInfo { Parent = "Oceania", Name = "Micronesia", Pop = 111542 },
                new CountryInfo { Parent = "Oceania", Name = "Solomon Islands", Pop = 552267 },
                new CountryInfo { Parent = "South America", Name = "Argentina", Pop = 40764561 },
                new CountryInfo { Parent = "South America", Name = "Bolivia", Pop = 10088108 },
                new CountryInfo { Parent = "South America", Name = "Brazil", Pop = 196655014 },
                new CountryInfo { Parent = "South America", Name = "Chile", Pop = 17269525 },
                new CountryInfo { Parent = "South America", Name = "Colombia", Pop = 46927125 },
                new CountryInfo { Parent = "South America", Name = "Ecuador", Pop = 14666055 },
                new CountryInfo { Parent = "South America", Name = "Guyana", Pop = 756040 },
                new CountryInfo { Parent = "South America", Name = "Paraguay", Pop = 6568290 },
                new CountryInfo { Parent = "South America", Name = "Peru", Pop = 29399817 },
                new CountryInfo { Parent = "South America", Name = "Suriname", Pop = 529419 },
                new CountryInfo { Parent = "South America", Name = "Uruguay", Pop = 3368595 },
                new CountryInfo { Parent = "South America", Name = "Venezuela", Pop = 29278000 },         
            };
           
            return data;
        }
    }
}
