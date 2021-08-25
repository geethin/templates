using GT.CLI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT.CLI
{
    public class Test
    {


        /// <summary>
        /// dto 生成测试
        /// </summary>
        /// <param name="entityPath"></param>
        public void TestDtoGen(string entityPath)
        {

            var gen = new DtoGenerate(entityPath);

            gen.GenerateDtos();
        }

        
    }
}
