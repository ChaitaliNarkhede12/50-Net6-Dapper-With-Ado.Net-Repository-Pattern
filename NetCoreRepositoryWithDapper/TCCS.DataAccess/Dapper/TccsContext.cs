using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.DataAccess.Dapper
{
    public class TccsContext : DbContext
    {
        public TccsContext() { }
        public TccsContext(DbContextOptions<TccsContext> options) : base(options) { }
    }
}
