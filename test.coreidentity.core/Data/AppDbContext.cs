using System;
using System.Collections.Generic;
using System.Text;
using test.coreidentity.core.Data;

namespace test.coreidentity.core
{
    public class AppDbContext
    {
        protected readonly ApplicationDbContext context;

        public AppDbContext(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
