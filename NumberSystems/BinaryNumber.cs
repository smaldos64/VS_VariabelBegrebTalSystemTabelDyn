﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using VariabelBegreb.Tools;

namespace VariabelBegreb.NumberSystems
{
    public class BinaryNumber : NumberSystem
    {
        static Key[] ValidKeysArray = { Key.D0, Key.D1 };

        public override bool IsKeyValid(Key ThisKey)
        {
            return (ValidKeysArray.Contains(ThisKey) || KeyHelper.IsKeyPressedValicControlKey(ThisKey));
        }

        public override string ConvertFromRadix10(int Radix10Number)
        {
            string ReturnString = " ";
            ConstRadixSystem ConstRadixSystem_Object = Const.FindRadixSystem(RadixNumber_ENUM.BINARY_NUMBER);

            if (null != ConstRadixSystem_Object)
            {
                ReturnString = base.ConvertFromRadix10(Radix10Number, (int)RadixNumber_ENUM.BINARY_NUMBER,
                    ConstRadixSystem_Object.RadixSpaceCounter, ConstRadixSystem_Object.RadixSpaceCharacter);
            }
            else
            {
                MessageBox.Show("Der er vist en SW bug her !!!");
            }

            return (ReturnString);
        }

        public override int ConvertToRadix10(string RadixStringToConvert)
        {
            int Radix10Value = base.ConvertToRadix10(RadixStringToConvert, RadixNumber_ENUM.BINARY_NUMBER);

            return (Radix10Value);
        }
    }
}