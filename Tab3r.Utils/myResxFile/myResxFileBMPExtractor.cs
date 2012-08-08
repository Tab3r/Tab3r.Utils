using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Resources;
using System.Collections;
using System.Drawing;

namespace Tab3r.Utils.myResxFile
{
    public static class myResxFileBMPExtractor
    {

        public void getBMPFiles(string resxFile)
        {
            // Create a Resource Reader
            ResXResourceReader rsxr = new ResXResourceReader(resxFile);

            // Create a enumerator
            IDictionaryEnumerator id = rsxr.GetEnumerator();

            int i = 0;
            foreach (DictionaryEntry d in rsxr)
            {

                Bitmap b = d.Value as Bitmap;

                if (b != null)
                {
                    b.Save(resxFile + "__" + i.ToString() + ".bmp");
                    i++;
                }

            }

            //Close the reader.
            rsxr.Close();
        }

    }
}
