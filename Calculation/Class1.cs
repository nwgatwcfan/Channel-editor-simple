using System;

namespace Calculation
{
    public class Calc
    {
        int XORByteArrayFunction(byte[] bytearray)
        {
            int sPos = 0;
            int XORvalue = 0;

            // recursively loop through each char in the character array
            while (sPos < bytearray.Length)
            {
                XORvalue ^= bytearray[sPos];
                ++sPos;
            }
            return (XORvalue);
        }

        private byte[] CharArrayToByteArrayFunction(char[] messagetosend)
        {
            // create a byte arry to hold chars...
            byte[] data = new byte[messagetosend.Length];

            // loop thru chars and convert to byte...
            for (int i = 0; i < messagetosend.Length; i++)
            {
                // convert char to byte and place in byte array...
                data[i] = Convert.ToByte(messagetosend[i]);
            }
            return (data);

        }

    }
    
}
