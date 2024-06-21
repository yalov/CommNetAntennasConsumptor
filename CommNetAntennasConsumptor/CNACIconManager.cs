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
            //Logging.Log("Change Icon");

            //string dcicon = Path.Combine(KSPUtil.ApplicationRootPath, "GameData/Squad/PartList/SimpleIcons/deployable_antenna.png");
            //Texture2D tex = new Texture2D(0, 0, TextureFormat.ARGB32, false);
            //tex.LoadImage(File.ReadAllBytes(dcicon));
            //GameDatabase.Instance.databaseTexture.Select(t => t.name).ToList().ForEach(n => Logging.Log(n));

            //modules.Remove(modules.Find(m => m.button.categoryName == "Procedural Chute"));

            var name = "Squad/PartList/SimpleIcons/deployable_antenna";
            var tex = GameDatabase.Instance.GetTexture(name, false /* asNormalMap */);
            Icon icon = new Icon("CNAC", tex, tex, true);

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