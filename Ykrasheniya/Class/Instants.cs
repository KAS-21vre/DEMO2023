using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykrasheniya
{
    internal class Instants
    {
        private static YkrasheniyaEntities _db;

        public static YkrasheniyaEntities GetContext()
        {
            if (_db == null)
            {
                _db = new YkrasheniyaEntities();

            }
            return _db;

        }

    }
}
