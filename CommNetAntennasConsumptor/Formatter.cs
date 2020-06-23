using System;
using System.Globalization;
using KSP.Localization;

namespace CommNetAntennasConsumptor
{
    static class Formatter
    {
        public static string StringRate(double value)
        {
            double v = Math.Abs(value);

            if      (v > 1.0 / 10)                            return Localizer.Format("#CAE_EC_S", value.ToString("F2"));
            else if (v > 1.0 / 60)                            return Localizer.Format("#CAE_EC_M", (value * 60).ToString("F1"));
            else if (v > 1.0 / 3600)                          return Localizer.Format("#CAE_EC_H", (value * 3600).ToString("F1")); 
            else if (v > 1.0 / KSPUtil.dateTimeFormatter.Day) return Localizer.Format("#CAE_EC_D", (value * KSPUtil.dateTimeFormatter.Day).ToString("F1")); 
            else                                              return Localizer.Format("#CAE_EC_Y", (value * KSPUtil.dateTimeFormatter.Year).ToString("F1")); 
        }
    }
}
