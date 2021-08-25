using GT.CLI.Common;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static GT.CLI.Common.ClassParseHelper;

namespace GT.CLI.Commands
{
    /// <summary>
    /// 数据仓储生成
    /// </summary>
    public class RepositoryGenerate : GenerateBase
    {
        public string EntityPath { get; set; }
        public string ServicePath { get; set; }
        public string SharePath { get; set; }
        public RepositoryGenerate(string entityPath, string servicePath)
        {
            EntityPath = entityPath;
            ServicePath = servicePath;
            SharePath = Path.Combine(servicePath, "..", "Share");
        }

        /// <summary>
        /// 生成仓储
        /// </summary>
        public void GenerateReponsitory()
        {
            // 获取生成需要的实体名称
            if (!File.Exists(EntityPath))
            {
                return;
            }
            var content = File.ReadAllText(EntityPath);
            var tree = CSharpSyntaxTree.ParseText(content);
            var root = tree.GetCompilationUnitRoot();
            var classDeclarationSyntax = root.DescendantNodes().OfType<ClassDeclarationSyntax>().Single();
            string className = classDeclarationSyntax.Identifier.ToString();
            // 获取数据库上下文信息
            var contextPath = Path.Combine(ServicePath, "..", "Data.Context");
            var cpl = new CompilationHelper(contextPath, "Data.Context");
            var classes = cpl.GetAllClasses();
            if (classes == null)
            {
                return;
            }
            var contextClass = cpl.GetClassNameByBaseType(classes, "IdentityDbContext")?.FirstOrDefault();
            if (contextClass == null)
            {
                contextClass = cpl.GetClassNameByBaseType(classes, "DbContext").FirstOrDefault();
            }
            var contextName = contextClass?.Name ?? "ContextBase";
            // 生成基础仓储实现类，替换模板变量并写入文件
            var tplContent = GetTplContent("Repository.tpl");
            tplContent = tplContent.Replace("{$ContextName}", contextName);
            SaveToFile(Path.Combine(ServicePath, "Repositories"), "Repository.cs", tplContent);
            // 生成当前实体的仓储服务
            tplContent = GetTplContent("MyRepository.tpl");
            tplContent = tplContent.Replace("{$EntityName}", className);
            tplContent = tplContent.Replace("{$ContextName}", contextName);
            SaveToFile(Path.Combine(ServicePath, "Repositories"), className + "Repository.cs", tplContent);
            Console.WriteLine("仓储生成完成");
        }

     
    }
}
