﻿using System;

namespace TiqSoft.ScreenAssistant.ScreenInfoRecognition
{
    public class WeaponDataAttribute : Attribute
    {
        public string Name { get; }
        public int NumberOfMods { get; }
        public string[] ExtraRecognitionNames { get; }

        public WeaponDataAttribute(string name, int numberOfMods, params string[] extraRecognitionNames)
        {
            this.Name = name;
            this.NumberOfMods = numberOfMods;
            this.ExtraRecognitionNames = extraRecognitionNames ?? new string[0];
        }
    }
}
