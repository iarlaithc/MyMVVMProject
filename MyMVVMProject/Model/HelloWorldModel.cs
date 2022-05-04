using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVMProject.Model
{
    public class HelloWorldModel
    {
        private List<string> repositoryData;
        public string ImportantInfo
        {
            get 
            {
                return ConcatenateData(repositoryData);
            }
        }
        public HelloWorldModel()
        {
            repositoryData = GetData();
        }

        private List<string> GetData()
        {
            repositoryData = new List<string>()
            {
                "Hello",
                "Boys"
            };
            return repositoryData;
        }
        
        private string ConcatenateData(List<string> dataList)
        {
            string importantInfo = dataList.ElementAt(0) + "," + dataList.ElementAt(1) + "!";
            return importantInfo;
        }

    }
}
