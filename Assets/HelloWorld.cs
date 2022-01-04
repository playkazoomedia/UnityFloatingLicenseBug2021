using UnityEditor;
using UnityEngine;

public static class HelloWorld
{
  public static void Print()
  {
    Debug.Log("\n======================================================\n\n\n\tHello World!\n\n\n======================================================\n\n\n");
  }
  
  public static void BuildAPK()
  {
      BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
      buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity"};
      buildPlayerOptions.locationPathName = "Assets/Builds/Android";
      buildPlayerOptions.target = BuildTarget.Android;
      buildPlayerOptions.options = BuildOptions.None;
      BuildPipeline.BuildPlayer(buildPlayerOptions);
  }
  
  public static void BuildIOS()
  {
      BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
      buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity"};
      buildPlayerOptions.locationPathName = "Assets/Builds/iOS";
      buildPlayerOptions.target = BuildTarget.iOS;
      buildPlayerOptions.options = BuildOptions.None;
      BuildPipeline.BuildPlayer(buildPlayerOptions);
  }
}
