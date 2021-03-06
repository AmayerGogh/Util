﻿using System;
using System.Linq.Expressions;
using Util.Ui.Components;

namespace Util.Ui.Services {
    /// <summary>
    /// 组件服务
    /// </summary>
    public interface IUiService<TModel> {
        /// <summary>
        /// 复选框
        /// </summary>
        /// <typeparam name="TProperty">属性类型</typeparam>
        /// <param name="expression">属性表达式</param>
        ICheckBox CheckBox<TProperty>( Expression<Func<TModel, TProperty>> expression );
        /// <summary>
        /// 滑动开关
        /// </summary>
        /// <typeparam name="TProperty">属性类型</typeparam>
        /// <param name="expression">属性表达式</param>
        ISlideToggle SlideToggle<TProperty>( Expression<Func<TModel, TProperty>> expression );
        /// <summary>
        /// 下拉列表
        /// </summary>
        /// <typeparam name="TProperty">属性类型</typeparam>
        /// <param name="expression">属性表达式</param>
        ISelect Select<TProperty>( Expression<Func<TModel, TProperty>> expression );
        /// <summary>
        /// 文本框
        /// </summary>
        /// <typeparam name="TProperty">属性类型</typeparam>
        /// <param name="expression">属性表达式</param>
        ITextBox TextBox<TProperty>( Expression<Func<TModel, TProperty>> expression );
    }
}
