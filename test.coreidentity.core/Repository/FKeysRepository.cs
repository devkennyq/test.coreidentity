using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.coreidentity.core.Data;
using test.coreidentity.core.Interfaces;
using test.coreidentity.core.Models;

namespace test.coreidentity.core.Repository
{
    public class FKeysRepository : AppDbContext, IFKeysRepository
    {
        readonly ILogger logger;

        public FKeysRepository(ApplicationDbContext context, ILogger<FKeysRepository> logger)
            : base(context)
        {
            this.logger = logger;
        }

        public async Task CreateData()
        {
            string sqlDNSUsers = "select * from DNS_Users";
            string sqlTableN = "insert into dbo.FKEY_Table{0} (UserId) values (@UserId)";

            using (var connection = new SqlConnection(context.Database.GetDbConnection().ConnectionString))
            {
                //Get dns_users (100)
                var dnsUsers = connection.Query<DnsUser>(sqlDNSUsers).ToList();
                if (dnsUsers != null && dnsUsers.Count > 0)
                {
                    int index = 0;

                    foreach (var dnsUser in dnsUsers)
                    {
                        //create records for each dbo.Table[N]
                        for (int i = 1; i <= 20; i++)
                        {
                            //create j times records each dnsuser.
                            for (int j = 0; j < 10; j++)
                            {
                                await connection.ExecuteAsync(string.Format(sqlTableN, i), new { UserId = dnsUser.UserId });
                            }
                        }

                        index++;

                        //
                        logger.LogInformation($"Table[{index}] complete.");
                    }

                    //
                    logger.LogInformation("DNSUsers complete.");
                }
            }
        }
    }
}
