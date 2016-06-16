using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace CANG2Data.Samples.Model
{
  public class DataConfiguration : DbConfiguration
  {
    public DataConfiguration()
    {
      SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
      SetDefaultConnectionFactory(new LocalDbConnectionFactory("v11.0"));
    }
  }
}