using System.Collections.Generic;
using System.IO;
using System.Linq;
using KSP.Localization;
using KSP.UI.Screens;
using RUI.Icons.Selectable;
using UnityEngine;


namespace CommNetAntennasConsumptor
{
    [KSPAddon(KSPAddon.Startup.EditorAny, false)]
    public class CNACIconManager : MonoBehaviour
    {
        private void ChangeIcon()
        {
            //string dcicon = Path.Combine(KSPUtil.ApplicationRootPath, "GameData/Squad/PartList/SimpleIcons/deployable_antenna.png");
            //Texture2D tex = new Texture2D(0, 0, TextureFormat.ARGB32, false);
            //tex.LoadImage(File.ReadAllBytes(dcicon));
            //GameDatabase.Instance.databaseTexture.Select(t => t.name).ToList().ForEach(n => Logging.Log(n));
            //modules.Remove(modules.Find(m => m.button.categoryName == "Procedural Chute"));
            
            //PartCategorizer.Category filterByFunction = PartCategorizer.Instance.filters.Find(f => f.button.categorydisplayName == "#autoLOC_453547"); //Filter by Function
            //Icon mysimpletest3 = PartCategorizer.Instance.iconLoader.GetIcon("CommNetAntennasConsumptor/SimpleIcons/mysimpletest3");
            //PartCategorizer.AddCustomSubcategoryFilter(filterByFunction, "mysimpletest3", "mysimpletest3", mysimpletest3, p => false);

            Icon icon = PartCategorizer.Instance.iconLoader.GetIcon("deployable_antenna");

            List<PartCategorizer.Category> modules = PartCategorizer.Instance.filters
                .Find(f => f.button.categorydisplayName == "#autoLOC_453705").subcategories; //Filter by Module

            modules.Select(m => m.button).Single(b => b.categoryName == 
            Localizer.Format("#CAE_ModuleGeneratorAntennaTitle")).SetIcon(icon);
            modules.Select(m => m.button).Single(b => b.categoryName == 
            Localizer.Format("#CAE_ModuleAntennaTogglerTitle")).SetIcon(icon);
        }

        private void Awake()
        {
            GameEvents.onGUIEditorToolbarReady.Add(ChangeIcon);
        }

        private void OnDestroy()
        {
            GameEvents.onGUIEditorToolbarReady.Remove(ChangeIcon);
        }
    }
}