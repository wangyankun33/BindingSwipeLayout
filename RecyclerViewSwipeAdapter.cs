using Android.Support.V7.Widget;
using Android.Views;
using Com.Chad.Library.Adapter.Base;
using Com.Daimajia.Swipe;
using Com.Daimajia.Swipe.Implments;
using Com.Daimajia.Swipe.Interfaces;
using Com.Daimajia.Swipe.Util;
using Java.Lang;
using System.Collections;
using System.Collections.Generic;

namespace WMSAndroid
{
/// <summary>
/// recyclerview 基础适配器
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class RecyclerViewAdapter<T> : BaseQuickAdapter where T : class
{
    protected RecyclerViewAdapter(int layoutResId, IList data) : base(layoutResId, data)
    {
    }
    protected override void Convert(Object p0, Object p1)
    {
        BaseViewHolder helper = (BaseViewHolder)p0;
        int position = helper.AdapterPosition;
        T item = default;
        if (p1 is String || p1.Class.Name == "java.lang.String")
        {
            item = p1.ToString() as T;
        }
        else
        {
            var propertyInfo = p1.GetType().GetProperty("Instance");
            item = propertyInfo == null ? null : propertyInfo.GetValue(p1, null) as T;
        }
        Converts(helper, item, position);
    }
    public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
    {
        base.OnBindViewHolder(holder, position);
    }
    /// <summary>
    /// wyk加载子项
    /// </summary>
    /// <param name="holder"></param>
    /// <param name="item"></param>
    /// <param name="position"></param>
    public abstract void Converts(BaseViewHolder holder, T item, int position);
    /// <summary>
    /// wyk设置空布局
    /// </summary>
    /// <param name="layoutResId">空布局Id</param>
    public new void SetEmptyView(int layoutResId = Resource.Layout.recyclerview_empty)
    {
        base.SetEmptyView(layoutResId);
        SetNewData(null);
    }
}
    /// <summary>
    /// recyclerview 带侧滑基础适配器
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class RecyclerViewSwipeAdapter<T> : RecyclerViewAdapter<T>, ISwipeAdapterInterface, ISwipeItemMangerInterface where T : class
    {
        public readonly SwipeItemRecyclerMangerImpl mItemManger;
        public RecyclerViewSwipeAdapter(int layoutResId, IList data) : base(layoutResId, data)
        {
            mItemManger = new SwipeItemRecyclerMangerImpl(this);
        }

        public int GetSwipeLayoutResourceId(int position)
        {
            return GetSwipeLayoutResourceId();
        }

        #region MyRegion
        public void OpenItem(int position)
        {
            mItemManger.OpenItem(position);
        }
        public void CloseItem(int position)
        {
            mItemManger.CloseItem(position);
            var swipeLayout = (SwipeLayout)GetViewByPosition(position, GetSwipeLayoutResourceId());
            swipeLayout.Close();
        }
        public void CloseAllExcept(SwipeLayout layout)
        {
            mItemManger.CloseAllExcept(layout);
        }
        public void CloseAllItems()
        {
            mItemManger.CloseAllItems();
        }
        public void RemoveShownLayouts(SwipeLayout layout)
        {
            mItemManger.RemoveShownLayouts(layout);
        }
        public bool IsOpen(int position)
        {
            return mItemManger.IsOpen(position);
        }
        public Attributes.Mode Mode { get => mItemManger.Mode; set => mItemManger.Mode = value; }
        public IList<Integer> OpenItems => mItemManger.OpenItems;
        public IList<SwipeLayout> OpenLayouts => mItemManger.OpenLayouts;
        #endregion

        /// <summary>
        /// 绑定视图 
        /// </summary>
        /// <param name="view"></param>
        /// <param name="position"></param>
        public void BindView(View view,int position)
        {
            mItemManger.BindView(view, position);
        }
        /// <summary>
        /// 设置滑动方式，比如设置单个滑动或允许多个滑动
        /// </summary>
        /// <param name="mode"></param>
        public void SetMode(Attributes.Mode mode)
        {
            mItemManger.Mode = mode;
        }
        /// <summary>
        /// 设置SwipelayoutId 比如:<see cref="Resource.Id.swipeLayout1"/>
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public abstract int GetSwipeLayoutResourceId();
    }
}
