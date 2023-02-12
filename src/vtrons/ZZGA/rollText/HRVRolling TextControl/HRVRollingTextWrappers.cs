﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using HighResolutionApps.Common.Schema;
using HighResolutionApps.Common.UI.Editor;
using HighResolutionApps.Interfaces;
using HrvVisualControlStyles;

namespace HighResolutionApps.VisualControls.HRVRollingTextControl_ZZGA
{
    /// <summary>
    /// 组件封装类 实现IVisualControlDescriptor接口
    /// </summary>
    class HRVUserControlWrappers : IVisualControlDescriptor
    {
        public static Plugin Plugin { get; set; }

        #region interface IVisualControlDescriptor

        /// <summary>
        /// 组件名称
        /// </summary>
        public string Name
        {
            get { return "1.滚动文本"; }
        }
        /// <summary>
        /// 组件标识
        /// </summary>
        public string PluginId
        {
            get { return Plugin.PluginId; }
        }
        /// <summary>
        /// 组件类型 需要修改
        /// </summary>
        public Type Type
        {
            get { return typeof(HRVRollingTextControl_ZZGA); }
        }
        /// <summary>
        /// 组件操作类型
        /// </summary>
        public ManipulatorKind ManipulatorKind
        {
            get { return ManipulatorKind.DragResizeRotateManipulator; }
        }
        /// <summary>
        /// 创建组件
        /// </summary>
        /// <returns></returns>
        public UIElement CreateControl()
        {
            return new HRVRollingTextControl_ZZGA();
        }
        /// <summary>
        /// 标签
        /// </summary>
        public object Tag
        {
            get;
            set;
        }
        /// <summary>
        /// 获取组件注册属性
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public ICustomTypeDescriptor getPropProxy(object o)
        {
            return (ICustomTypeDescriptor)new HRVUserControlPropProxy(o);
        }
        #endregion interface IVisualControlDescriptor
    }

    /// <summary>
    /// 组件属性注册封装
    /// </summary>
    public class HRVUserControlPropProxy : HighResolutionApps.Common.Schema.BasePropProxy
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="controlledObject"></param>
        public HRVUserControlPropProxy(object controlledObject)
            : base(controlledObject)
        {
        }

        /// <summary>
        /// 组件属性注册
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            List<PropertyWrapper> result = new List<PropertyWrapper>();
            // 用户自定义属性请写明组别和属性说明
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "TitleSize", null, result, "字体大小", "自定义");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "TitleForegroundColor", typeof(BrushEditor), result, "字体颜色", "自定义");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "TextTitle", null, result, "文本内容", "自定义");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "TitleFontFamily", null, result, "字体样式", "自定义");

            //RegisterProperty(typeof(HRVRolling_TextControl), "TitleLong", null, result, "标题滚动长度", "自定义");
            //RegisterProperty(typeof(HRVRolling_TextControl), "TitleTime", null, result, "标题滚动时间", "自定义");



            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "TextLength", null, result, "文本长度, 用于设置计算文本toubu滚动滚动像素", "自定义");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "TextStep", null, result, "文本滚动框步长, 用于设置计算文本滚动前进时幅度", "自定义");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "TextBlockLength", null, result, "文本框长度, 用于计算文本滚动时动态位置", "自定义");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "TextPostion", null, result, "文本滚动位置，用于大屏渲染节点同步通讯，不要手动修改", "自定义");   
            // -------------------------------------------------------------------------------------------------------
            // 组别：基础
            RegisterProperty(typeof(FrameworkElement), "Name", null, result, "组件名称", "基础");
            RegisterProperty(typeof(FrameworkElement), "Cursor", null, result, "光标", "基础");
            RegisterProperty(typeof(FrameworkElement), "IsEnabled", null, result, "使能", "基础");
            RegisterProperty(typeof(FrameworkElement), "Background", typeof(BrushEditor), result, "背景", "基础");
            RegisterProperty(typeof(FrameworkElement), "Opacity", null, result, "透明度", "基础");
            RegisterProperty(typeof(UIElement), "Visibility", null, result, "是否可见", "基础");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "IsEditableInOperater", null, result, "是否可以任意移动、改变大小、角度改变", "基础");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "IsMustInOnlyOneMachine", null, result, "是否可以跨屏，跨渲染节点显示", "基础");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "MemoryRequest", null, result, "内存需求", "基础");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "ControlInstanceDes", null, result, "组件示例描述", "基础");
            // 位置尺寸
            RegisterProperty(typeof(FrameworkElement), "Canvas.Top", null, result, "上侧位置", "位置尺寸");
            RegisterProperty(typeof(FrameworkElement), "Canvas.Left", null, result, "左侧位置", "位置尺寸");
            RegisterProperty(typeof(FrameworkElement), "Width", null, result, "宽度", "位置尺寸");
            RegisterProperty(typeof(FrameworkElement), "Height", null, result, "高度", "位置尺寸");

            // 组别: 外观
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "ControlInstanceMainTitle", null, result, "窗口默认主标题", "外观");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "ControlInstanceSubTitle", null, result, "窗口默认副标题", "外观");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "WindowStyleName", typeof(SelectStylesEditor), result, "样式名称", "外观");
            // 组别：渲染
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "RenderMethod", null, result, "加载方式", "渲染");
            RegisterProperty(typeof(HRVRollingTextControl_ZZGA), "RenderOrder", null, result, "渲染优先级", "渲染");

            // 用户自定义属性请写明组别和属性说明

            return new PropertyDescriptorCollection(result.ToArray());
        }


        /// <summary>
        /// 注册属性
        /// </summary>
        /// <param name="objectType"></param>
        /// <param name="sourceProperty"></param>
        /// <param name="editor"></param>
        /// <param name="result"></param>
        /// <param name="description">描述</param>
        /// <param name="group">组别</param>
        void RegisterProperty(Type objectType, string sourceProperty, Type editor, List<PropertyWrapper> result, string description, string group)
        {
            try
            {
                PropertyInfo info = new PropertyInfo();
                info.SourceProperty = sourceProperty;
                info.Editor = editor;
                info.Description = description;
                info.Group = group;
                result.Add(new PropertyWrapper(ControlledObject, info));
            }
            catch (Exception ex)
            {
                SystemHelper.logger.LogError(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName,
                System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString(), ex.ToString());
            }

        }

    }
}
