﻿namespace SchoolProject.Domain.Common;

public interface ILocalizeEntity
{
    string? Localize(string? textAr, string? textEn)
    {
        var culture = Thread.CurrentThread.CurrentCulture;

        if (culture.TwoLetterISOLanguageName.Equals("ar", StringComparison.OrdinalIgnoreCase))
            return textAr;

        return textEn;
    }
}