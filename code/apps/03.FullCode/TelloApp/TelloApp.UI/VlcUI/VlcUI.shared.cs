using System;
using System.Threading.Tasks;
using Microsoft.Maui.Handlers;

namespace TelloApp.UI
{

    public interface IVlcUI : IView
    {
    }


    public class VlcUI : View, IVlcUI
    {

    }


    partial class VlcUIHandler
    {
        public static IPropertyMapper<VlcUI, VlcUIHandler> MapMapper = new PropertyMapper<VlcUI, VlcUIHandler>(ViewHandler.ViewMapper)
        { };

        public VlcUIHandler() : base(MapMapper)
        { }
    }

}
