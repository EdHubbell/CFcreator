using System.Reflection;
using System.Windows.Forms;

namespace XferPrintLib.Utility
{
    public static class PropertyGridHelper
    {
        public static void PropertyGridSetLabelColumnWidth(this PropertyGrid Pgrid, int width)
        {
            //FieldInfo f_info = Pgrid?.GetType().GetField("gridView", BindingFlags.Instance | BindingFlags.NonPublic);
            //Control view = f_info?.GetValue(Pgrid) as Control;
            //MethodInfo m_info = view?.GetType().GetMethod("MoveSplitterTo", BindingFlags.Instance | BindingFlags.NonPublic);
            //m_info?.Invoke(view, new object[] { width });

            MoveSplitterTo(Pgrid, width);
        }
        /// <summary>
        /// Gets the (private) PropertyGridView instance.
        /// </summary>
        /// <param name="propertyGrid">The property grid.</param>
        /// <returns>The PropertyGridView instance.</returns>
        private static object GetPropertyGridView(PropertyGrid propertyGrid)
        {
            //private PropertyGridView GetPropertyGridView();
            //PropertyGridView is an internal class...
            MethodInfo methodInfo = typeof(PropertyGrid).GetMethod("GetPropertyGridView", BindingFlags.NonPublic | BindingFlags.Instance);
            return methodInfo.Invoke(propertyGrid, new object[] { });
        }

        /// <summary>
        /// Moves the splitter to the supplied horizontal position.
        /// </summary>
        /// <param name="propertyGrid">The property grid.</param>
        /// <param name="xpos">The horizontal position.</param>
        private static void MoveSplitterTo(this PropertyGrid propertyGrid, int xpos)
        {
            //System.Windows.Forms.PropertyGridInternal.PropertyGridView
            object gridView = GetPropertyGridView(propertyGrid);

            //private void MoveSplitterTo(int xpos);
            MethodInfo methodInfo = gridView.GetType().GetMethod("MoveSplitterTo", BindingFlags.NonPublic | BindingFlags.Instance);
            methodInfo.Invoke(gridView, new object[] { xpos });
        }
    }
}
