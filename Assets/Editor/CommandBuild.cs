using UnityEngine;
using UnityEditor;

public class CommandBuild
{
	public static void BuildWindowsStandalone()
	{
		string[] levels = {"Assets/Scenes/Main.unity"};
        string filename = string.Empty;


        filename = "Assets/Resources/icons/msp.png";
        Texture2D[] icon = PlayerSettings.GetIconsForTargetGroup(BuildTargetGroup.Standalone);//;new Texture2D[7];
        Debug.LogError("icons size " + icon.Length);
        for (int i = 0; i < icon.Length; i++)
        {
            icon[i] = (Texture2D)AssetDatabase.LoadAssetAtPath(filename, typeof(Texture2D));
        }
        Debug.LogError("replace file from " + filename + " to all icons");
        PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Standalone, icon);
        FileUtil.ReplaceFile(filename, "Assets/Annex/Textures/UI/defaulticon.png");  //用这种方式把defaulticon替换掉
        Debug.LogError("replace file from " + filename + " to Assets/Annex/Textures/UI/defaulticon.png");
        PlayerSettings.productName = "MySwingPro";
        BuildPipeline.BuildPlayer(levels, "MySwingPro.exe", BuildTarget.StandaloneWindows, BuildOptions.None);

    }
}