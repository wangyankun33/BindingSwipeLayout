# BindingSwipeLayout
Android源版本
<br/>
AndroidSwipeLayout-1.2.0
<br/>
Xamairn.Android版本:Android9
<br/>
依赖项
Xamarin.Android.Support.v7.RecyclerView:28.0.0.3
<br/>
Xamarin.Android.Support.v7.AppCompat:28.0.0.3
<br/>
Xamarin.Android.Support.v4:28.0.0.3
<br/>

问题1：点击菜单项，侧滑不关闭
```
 public void CloseItem(int position)
 {
     mItemManger.CloseItem(position);
     var swipeLayout = (SwipeLayout)GetViewByPosition(position, GetSwipeLayoutResourceId());
     swipeLayout.Close();
 }
```
