﻿#region

using System;

#endregion

namespace OldMacDonald.Domain.Animals
{
    public class Dog : AnimalBase
    {
        public override AnimalType Type
        {
            get { return AnimalType.Dog; }
        }

        public override string AnimalName
        {
            get { return "dog"; }
        }

        public override string AnimalSound
        {
            get { return "woof"; }
        }

        protected override string GetAnimalNameAndSound()
        {
            return _verse.Replace("@newLine", Environment.NewLine)
                .Replace("@animal", AnimalName)
                .Replace("@sound", AnimalSound)
                .ToString();
        }
    }
}