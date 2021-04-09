using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 菜单/ 自引用
    /// </summary>
    public class Menu : EntityBase
    {
        /// <summary>
        /// 菜单名称/唯一
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 菜单展示名称
        /// </summary>
        [MaxLength(50)]
        public string DisplayName { get; set; }
        /// <summary>
        /// 菜单类型
        /// </summary>
        [MaxLength(50)]
        public string Type { get; set; }
        /// <summary>
        /// 菜单图标
        /// </summary>
        [MaxLength(20)]
        public string Icon { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        [MaxLength(100)]
        public string Path { get; set; }
        /// <summary>
        /// 是否启用/有效
        /// </summary>
        public bool IsValid { get; set; } = true;
        /// <summary>
        /// 菜单层级
        /// </summary>
        public short Level { get; set; }
        public Guid ParentId { get; set; }
        /// <summary>
        /// 父菜单
        /// </summary>
        [ForeignKey("ParentId")]
        public Menu Parent { get; set; }
        /// <summary>
        /// 子菜单
        /// </summary>
        public List<Menu> Children { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [MaxLength(200)]
        public string Description { get; set; }
        /// <summary>
        /// 多对多关联角色
        /// </summary>
        public List<Role> Roles { get; set; }
    }
}
