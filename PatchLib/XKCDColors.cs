using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace PatchLib
{

public static class XKCDColors_Patched 
{
  [Obsolete("This has been replaced by the Color.A(float) extension method.")]
  public static float NextColorAlpha = 1f;

  public static Color KSPBadassGreen
  {
    get
    {
        return XKCDColors.RedOrange;
  //    return new Color(0.7215686f, 0.792156f, 0.4470588f, 1f);
    }
  }

  public static Color KSPNotSoGoodOrange
  {
    get
    {
        return XKCDColors.AquaBlue;
  //    return new Color(1f, 0.694f, 0.0f, 1f);
    }
  }

  public static Color KSPUIGrey
  {
    get
    {
        return new Color(0.4823529411764706f, 0.4666666666666667f, 0.807843137254902f);
       // return new Color(0.002122261f, 0.002260669f, 0.002399077f, 1f);
    }
  }

  public static Color KSPUnnamedCyan
  {
    get
    {
      return new Color(0.001460977f, 0.002891196f, 0.002829681f, 1f);
    }
  }

  public static Color KSPNeutralUIGrey
  {
    get
    {
        return new Color(0.2823529411764706f, 0.2666666666666667f, 0.607843137254902f);
     // return new Color(0.9960784f, 0.9960784f, 0.9960784f, 1f);
    }
  }

  public static Color CloudyBlue
  {
    get
    {
      return new Color(0.6745098f, 0.7607843f, 0.8509804f, 1f);
    }
  }

  public static Color DarkPastelGreen
  {
    get
    {
      return new Color(0.3372549f, 0.682353f, 0.3411765f, 1f);
    }
  }

  public static Color Dust
  {
    get
    {
      return new Color(0.6980392f, 0.6f, 0.4313726f, 1f);
    }
  }

  public static Color ElectricLime
  {
    get
    {
        return XKCDColors.BlueGrey;
       // return new Color(0.6588235f, 1f, 0.01568628f, 1f);
    }
  }

  public static Color FreshGreen
  {
    get
    {
      return new Color(0.4117647f, 0.8470588f, 0.3098039f, 1f);
    }
  }

  public static Color LightEggplant
  {
    get
    {
      return new Color(0.5372549f, 0.2705882f, 0.5215687f, 1f);
    }
  }

  public static Color NastyGreen
  {
    get
    {
      return new Color(0.4392157f, 0.6980392f, 0.2470588f, 1f);
    }
  }

  public static Color ReallyLightBlue
  {
    get
    {
      return new Color(0.8313726f, 1f, 1f, 1f);
    }
  }

  public static Color Tea
  {
    get
    {
      return new Color(0.3960784f, 0.6705883f, 0.4862745f, 1f);
    }
  }

  public static Color WarmPurple
  {
    get
    {
      return new Color(0.5843138f, 0.1803922f, 0.5607843f, 1f);
    }
  }

  public static Color YellowishTan
  {
    get
    {
      return new Color(0.9882353f, 0.9882353f, 0.5058824f, 1f);
    }
  }

  public static Color Cement
  {
    get
    {
      return new Color(0.6470588f, 0.6392157f, 0.5686275f, 1f);
    }
  }

  public static Color DarkGrassGreen
  {
    get
    {
      return new Color(0.2196078f, 0.5019608f, 0.01568628f, 1f);
    }
  }

  public static Color DustyTeal
  {
    get
    {
      return new Color(0.2980392f, 0.5647059f, 0.5215687f, 1f);
    }
  }

  public static Color GreyTeal
  {
    get
    {
      return new Color(0.3686275f, 0.6078432f, 0.5411765f, 1f);
    }
  }

  public static Color MacaroniAndCheese
  {
    get
    {
      return new Color(0.9372549f, 0.7058824f, 0.2078431f, 1f);
    }
  }

  public static Color PinkishTan
  {
    get
    {
      return new Color(0.8509804f, 0.6078432f, 0.509804f, 1f);
    }
  }

  public static Color Spruce
  {
    get
    {
      return new Color(0.03921569f, 0.372549f, 0.2196078f, 1f);
    }
  }

  public static Color StrongBlue
  {
    get
    {
      return new Color(0.04705882f, 0.02352941f, 0.9686275f, 1f);
    }
  }

  public static Color ToxicGreen
  {
    get
    {
      return new Color(0.3803922f, 0.8705882f, 0.1647059f, 1f);
    }
  }

  public static Color WindowsBlue
  {
    get
    {
      return new Color(68.0f * (float)Math.E / 857.0f, 0.4705882f, 0.7490196f, 1f);
    }
  }

  public static Color BlueBlue
  {
    get
    {
      return new Color(0.1333333f, 0.2588235f, 0.7803922f, 1f);
    }
  }

  public static Color BlueWithAHintOfPurple
  {
    get
    {
      return new Color(0.3254902f, 0.2352941f, 0.7764706f, 1f);
    }
  }

  public static Color Booger
  {
    get
    {
      return new Color(0.6078432f, 0.7098039f, 0.2352941f, 1f);
    }
  }

  public static Color BrightSeaGreen
  {
    get
    {
      return new Color(0.01960784f, 1f, 0.6509804f, 1f);
    }
  }

  public static Color DarkGreenBlue
  {
    get
    {
      return new Color(0.1215686f, 0.3882353f, 0.3411765f, 1f);
    }
  }

  public static Color DeepTurquoise
  {
    get
    {
      return new Color(0.003921569f, 0.4509804f, 0.454902f, 1f);
    }
  }

  public static Color GreenTeal
  {
    get
    {
      return new Color(0.04705882f, 0.7098039f, 0.4666667f, 1f);
    }
  }

  public static Color StrongPink
  {
    get
    {
      return new Color(1f, 0.02745098f, 0.5372549f, 1f);
    }
  }

  public static Color Bland
  {
    get
    {
      return new Color(0.6862745f, 0.6588235f, 0.5450981f, 1f);
    }
  }

  public static Color DeepAqua
  {
    get
    {
      return new Color(0.03137255f, 0.4705882f, 0.4980392f, 1f);
    }
  }

  public static Color LavenderPink
  {
    get
    {
      return new Color(0.8666667f, 0.5215687f, 0.8431373f, 1f);
    }
  }

  public static Color LightMossGreen
  {
    get
    {
      return new Color(0.6509804f, 0.7843137f, 0.4588235f, 1f);
    }
  }

  public static Color LightSeafoamGreen
  {
    get
    {
      return new Color(0.654902f, 1f, 0.7098039f, 1f);
    }
  }

  public static Color OliveYellow
  {
    get
    {
      return new Color(0.7607843f, 0.7176471f, 0.03529412f, 1f);
    }
  }

  public static Color PigPink
  {
    get
    {
      return new Color(0.9058824f, 0.5568628f, 0.6470588f, 1f);
    }
  }

  public static Color DeepLilac
  {
    get
    {
      return new Color(0.5882353f, 0.4313726f, 0.7411765f, 1f);
    }
  }

  public static Color Desert
  {
    get
    {
      return new Color(0.8f, 0.6784314f, 0.3764706f, 1f);
    }
  }

  public static Color DustyLavender
  {
    get
    {
      return new Color(0.6745098f, 0.5254902f, 0.6588235f, 1f);
    }
  }

  public static Color PurpleyGrey
  {
    get
    {
      return new Color(0.5803922f, 0.4941176f, 0.5803922f, 1f);
    }
  }

  public static Color Purply
  {
    get
    {
      return new Color(0.5960785f, 0.2470588f, 0.6980392f, 1f);
    }
  }

  public static Color CandyPink
  {
    get
    {
      return new Color(1f, 0.3882353f, 0.9137255f, 1f);
    }
  }

  public static Color LightPastelGreen
  {
    get
    {
      return new Color(0.6980392f, 0.9843137f, 0.6470588f, 1f);
    }
  }

  public static Color BoringGreen
  {
    get
    {
      return new Color(0.3882353f, 0.7019608f, 0.3960784f, 1f);
    }
  }

  public static Color KiwiGreen
  {
    get
    {
      return new Color(0.5568628f, 0.8980392f, 0.2470588f, 1f);
    }
  }

  public static Color LightGreyGreen
  {
    get
    {
      return new Color(0.7176471f, 0.8823529f, 0.6313726f, 1f);
    }
  }

  public static Color OrangePink
  {
    get
    {
      return new Color(1f, 0.4352941f, 0.3215686f, 1f);
    }
  }

  public static Color TeaGreen
  {
    get
    {
      return new Color(0.7411765f, 0.972549f, 0.6392157f, 1f);
    }
  }

  public static Color VeryLightBrown
  {
    get
    {
      return new Color(0.827451f, 0.7137255f, 0.5137255f, 1f);
    }
  }

  public static Color EggShell
  {
    get
    {
      return new Color(1f, 0.9882353f, 0.7686275f, 1f);
    }
  }

  public static Color EggplantPurple
  {
    get
    {
      return new Color(0.2627451f, 0.01960784f, 0.254902f, 1f);
    }
  }

  public static Color PowderPink
  {
    get
    {
      return new Color(1f, 0.6980392f, 0.8156863f, 1f);
    }
  }

  public static Color ReddishGrey
  {
    get
    {
      return new Color(0.6f, 0.4588235f, 0.4392157f, 1f);
    }
  }

  public static Color BabyShitBrown
  {
    get
    {
      return new Color(0.6784314f, 0.5647059f, 0.05098039f, 1f);
    }
  }

  public static Color Liliac
  {
    get
    {
      return new Color(0.7686275f, 0.5568628f, 0.9921569f, 1f);
    }
  }

  public static Color StormyBlue
  {
    get
    {
      return new Color(0.3137255f, 0.4823529f, 0.6117647f, 1f);
    }
  }

  public static Color UglyBrown
  {
    get
    {
      return new Color(0.4901961f, 0.4431373f, 0.01176471f, 1f);
    }
  }

  public static Color Custard
  {
    get
    {
      return new Color(1f, 0.9921569f, 0.4705882f, 1f);
    }
  }

  public static Color DarkishPink
  {
    get
    {
      return new Color(0.854902f, 0.2745098f, 0.4901961f, 1f);
    }
  }

  public static Color DeepBrown
  {
    get
    {
      return new Color(0.254902f, 0.007843138f, 0.0f, 1f);
    }
  }

  public static Color GreenishBeige
  {
    get
    {
      return new Color(0.7882353f, 0.8196079f, 0.4745098f, 1f);
    }
  }

  public static Color Manilla
  {
    get
    {
      return new Color(1f, 0.9803922f, 0.5254902f, 1f);
    }
  }

  public static Color OffBlue
  {
    get
    {
      return new Color(0.3372549f, 0.5176471f, 0.682353f, 1f);
    }
  }

  public static Color BattleshipGrey
  {
    get
    {
      return new Color(0.4196078f, 0.4862745f, 0.5215687f, 1f);
    }
  }

  public static Color BrownyGreen
  {
    get
    {
      return new Color(0.4352941f, 0.4235294f, 0.03921569f, 1f);
    }
  }

  public static Color Bruise
  {
    get
    {
      return new Color(0.4941176f, 0.2509804f, 0.4431373f, 1f);
    }
  }

  public static Color KelleyGreen
  {
    get
    {
      return new Color(0.0f, 0.5764706f, 68.0f * (float)Math.E / 857.0f, 1f);
    }
  }

  public static Color SicklyYellow
  {
    get
    {
      return new Color(0.8156863f, 0.8941177f, 0.1607843f, 1f);
    }
  }

  public static Color SunnyYellow
  {
    get
    {
      return new Color(1f, 0.9764706f, 0.09019608f, 1f);
    }
  }

  public static Color Azul
  {
    get
    {
      return new Color(0.1137255f, 0.3647059f, 0.9254902f, 1f);
    }
  }

  public static Color Darkgreen
  {
    get
    {
      return new Color(0.01960784f, 0.2862745f, 0.02745098f, 1f);
    }
  }

  public static Color Green_Yellow
  {
    get
    {
      return new Color(0.7098039f, 0.8078431f, 0.03137255f, 1f);
    }
  }

  public static Color Lichen
  {
    get
    {
      return new Color(0.5607843f, 0.7137255f, 0.4823529f, 1f);
    }
  }

  public static Color LightLightGreen
  {
    get
    {
      return new Color(0.7843137f, 1f, 0.6901961f, 1f);
    }
  }

  public static Color PaleGold
  {
    get
    {
      return new Color(0.9921569f, 0.8705882f, 0.4235294f, 1f);
    }
  }

  public static Color SunYellow
  {
    get
    {
      return new Color(1f, 0.8745098f, 0.1333333f, 1f);
    }
  }

  public static Color TanGreen
  {
    get
    {
      return new Color(0.6627451f, 0.7450981f, 0.4392157f, 1f);
    }
  }

  public static Color Burple
  {
    get
    {
      return new Color(0.4078431f, 0.1960784f, 0.8901961f, 1f);
    }
  }

  public static Color Butterscotch
  {
    get
    {
      return new Color(0.9921569f, 0.6941177f, 0.2784314f, 1f);
    }
  }

  public static Color Toupe
  {
    get
    {
      return new Color(0.7803922f, 0.6745098f, 0.4901961f, 1f);
    }
  }

  public static Color DarkCream
  {
    get
    {
      return new Color(1f, 0.9529412f, 0.6039216f, 1f);
    }
  }

  public static Color IndianRed
  {
    get
    {
      return new Color(0.5215687f, 0.05490196f, 0.01568628f, 1f);
    }
  }

  public static Color LightLavendar
  {
    get
    {
      return new Color(0.9372549f, 0.7529412f, 0.9960784f, 1f);
    }
  }

  public static Color PoisonGreen
  {
    get
    {
      return new Color(0.2509804f, 0.9921569f, 0.07843138f, 1f);
    }
  }

  public static Color BabyPukeGreen
  {
    get
    {
      return new Color(0.7137255f, 0.7686275f, 0.02352941f, 1f);
    }
  }

  public static Color BrightYellowGreen
  {
    get
    {
      return new Color(0.6156863f, 1f, 0.0f, 1f);
    }
  }

  public static Color CharcoalGrey
  {
    get
    {
      return new Color(0.2352941f, 0.254902f, 0.2588235f, 1f);
    }
  }

  public static Color Squash
  {
    get
    {
      return new Color(0.9490196f, 0.6705883f, 0.08235294f, 1f);
    }
  }

  public static Color Cinnamon
  {
    get
    {
      return new Color(0.6745098f, 0.3098039f, 0.02352941f, 1f);
    }
  }

  public static Color LightPeaGreen
  {
    get
    {
      return new Color(0.7686275f, 0.9960784f, 0.509804f, 1f);
    }
  }

  public static Color RadioactiveGreen
  {
    get
    {
      return new Color(0.172549f, 0.9803922f, 0.1215686f, 1f);
    }
  }

  public static Color RawSienna
  {
    get
    {
      return new Color(0.6039216f, 0.3843137f, 0.0f, 1f);
    }
  }

  public static Color BabyPurple
  {
    get
    {
      return new Color(0.7921569f, 0.6078432f, 0.9686275f, 1f);
    }
  }

  public static Color Cocoa
  {
    get
    {
      return new Color(0.5294118f, 0.372549f, 0.2588235f, 1f);
    }
  }

  public static Color LightRoyalBlue
  {
    get
    {
      return new Color(0.227451f, 0.1803922f, 0.9960784f, 1f);
    }
  }

  public static Color Orangeish
  {
    get
    {
      return new Color(0.9921569f, 0.5529412f, 0.2862745f, 1f);
    }
  }

  public static Color RustBrown
  {
    get
    {
      return new Color(0.5450981f, 0.1921569f, 0.01176471f, 1f);
    }
  }

  public static Color SandBrown
  {
    get
    {
      return new Color(0.7960784f, 0.6470588f, 0.3764706f, 1f);
    }
  }

  public static Color Swamp
  {
    get
    {
      return new Color(0.4117647f, 0.5137255f, 0.2235294f, 1f);
    }
  }

  public static Color TealishGreen
  {
    get
    {
      return new Color(0.04705882f, 0.8627451f, 0.4509804f, 1f);
    }
  }

  public static Color BurntSiena
  {
    get
    {
      return new Color(0.7176471f, 0.3215686f, 0.01176471f, 1f);
    }
  }

  public static Color Camo
  {
    get
    {
      return new Color(0.4980392f, 0.5607843f, 0.3058824f, 1f);
    }
  }

  public static Color DuskBlue
  {
    get
    {
      return new Color(0.1490196f, 0.3254902f, 0.5529412f, 1f);
    }
  }

  public static Color Fern
  {
    get
    {
      return new Color(0.3882353f, 0.6627451f, 0.3137255f, 1f);
    }
  }

  public static Color OldRose
  {
    get
    {
      return new Color(0.7843137f, 0.4980392f, 0.5372549f, 1f);
    }
  }

  public static Color PaleLightGreen
  {
    get
    {
      return new Color(0.6941177f, 0.9882353f, 0.6f, 1f);
    }
  }

  public static Color PeachyPink
  {
    get
    {
      return new Color(1f, 0.6039216f, 0.5411765f, 1f);
    }
  }

  public static Color RosyPink
  {
    get
    {
      return new Color(0.9647059f, 0.4078431f, 0.5568628f, 1f);
    }
  }

  public static Color LightBluishGreen
  {
    get
    {
      return new Color(0.4627451f, 0.9921569f, 0.6588235f, 1f);
    }
  }

  public static Color LightBrightGreen
  {
    get
    {
      return new Color(0.3254902f, 0.9960784f, 0.3607843f, 1f);
    }
  }

  public static Color LightNeonGreen
  {
    get
    {
      return new Color(0.3058824f, 0.9921569f, 0.3294118f, 1f);
    }
  }

  public static Color LightSeafoam
  {
    get
    {
      return new Color(0.627451f, 0.9960784f, 0.7490196f, 1f);
    }
  }

  public static Color TiffanyBlue
  {
    get
    {
      return new Color(0.4823529f, 0.9490196f, 0.854902f, 1f);
    }
  }

  public static Color WashedOutGreen
  {
    get
    {
      return new Color(0.7372549f, 0.9607843f, 0.6509804f, 1f);
    }
  }

  public static Color BrownyOrange
  {
    get
    {
      return new Color(0.7921569f, 0.4196078f, 0.007843138f, 1f);
    }
  }

  public static Color NiceBlue
  {
    get
    {
      return new Color(0.0627451f, 0.4784314f, 0.6901961f, 1f);
    }
  }

  public static Color Sapphire
  {
    get
    {
      return new Color(0.1294118f, 0.2196078f, 0.6705883f, 1f);
    }
  }

  public static Color GreyishTeal
  {
    get
    {
      return new Color(0.4431373f, 0.6235294f, 0.5686275f, 1f);
    }
  }

  public static Color OrangeyYellow
  {
    get
    {
      return new Color(0.9921569f, 0.7254902f, 0.08235294f, 1f);
    }
  }

  public static Color Parchment
  {
    get
    {
      return new Color(0.9960784f, 0.9882353f, 0.6862745f, 1f);
    }
  }

  public static Color Straw
  {
    get
    {
      return new Color(0.9882353f, 0.9647059f, 0.4745098f, 1f);
    }
  }

  public static Color VeryDarkBrown
  {
    get
    {
      return new Color(0.1137255f, 0.007843138f, 0.0f, 1f);
    }
  }

  public static Color Terracota
  {
    get
    {
      return new Color(0.7960784f, 0.4078431f, 0.2627451f, 1f);
    }
  }

  public static Color UglyBlue
  {
    get
    {
      return new Color(0.1921569f, 0.4f, 0.5411765f, 1f);
    }
  }

  public static Color ClearBlue
  {
    get
    {
      return new Color(0.1411765f, 0.4784314f, 0.9921569f, 1f);
    }
  }

  public static Color Creme
  {
    get
    {
      return new Color(1f, 1f, 0.7137255f, 1f);
    }
  }

  public static Color FoamGreen
  {
    get
    {
      return new Color(0.5647059f, 0.9921569f, 0.6627451f, 1f);
    }
  }

  public static Color Grey_Green
  {
    get
    {
      return new Color(0.5254902f, 0.6313726f, 0.4901961f, 1f);
    }
  }

  public static Color LightGold
  {
    get
    {
      return new Color(0.9921569f, 0.8627451f, 0.3607843f, 1f);
    }
  }

  public static Color SeafoamBlue
  {
    get
    {
      return new Color(0.4705882f, 0.8196079f, 0.7137255f, 1f);
    }
  }

  public static Color Topaz
  {
    get
    {
      return new Color(0.07450981f, 0.7333333f, 0.6862745f, 1f);
    }
  }

  public static Color VioletPink
  {
    get
    {
      return new Color(0.9843137f, 0.372549f, 0.9882353f, 1f);
    }
  }

  public static Color Wintergreen
  {
    get
    {
      return new Color(0.1254902f, 0.9764706f, 0.5254902f, 1f);
    }
  }

  public static Color YellowTan
  {
    get
    {
      return new Color(1f, 0.8901961f, 0.4313726f, 1f);
    }
  }

  public static Color DarkFuchsia
  {
    get
    {
      return new Color(0.6156863f, 0.02745098f, 0.3490196f, 1f);
    }
  }

  public static Color IndigoBlue
  {
    get
    {
      return new Color(0.227451f, 0.09411765f, 0.6941177f, 1f);
    }
  }

  public static Color LightYellowishGreen
  {
    get
    {
      return new Color(0.7607843f, 1f, 0.5372549f, 1f);
    }
  }

  public static Color PaleMagenta
  {
    get
    {
      return new Color(0.8431373f, 0.4039216f, 0.6784314f, 1f);
    }
  }

  public static Color RichPurple
  {
    get
    {
      return new Color(0.4470588f, 0.0f, 0.345098f, 1f);
    }
  }

  public static Color SunflowerYellow
  {
    get
    {
      return new Color(1f, 0.854902f, 0.01176471f, 1f);
    }
  }

  public static Color Green_Blue
  {
    get
    {
      return new Color(0.003921569f, 0.7529412f, 0.5529412f, 1f);
    }
  }

  public static Color Leather
  {
    get
    {
      return new Color(0.6745098f, 0.454902f, 0.2039216f, 1f);
    }
  }

  public static Color RacingGreen
  {
    get
    {
      return new Color(0.003921569f, 0.2745098f, 0.0f, 1f);
    }
  }

  public static Color VividPurple
  {
    get
    {
      return new Color(0.6f, 0.0f, 0.9803922f, 1f);
    }
  }

  public static Color DarkRoyalBlue
  {
    get
    {
      return new Color(0.007843138f, 0.02352941f, 0.4352941f, 1f);
    }
  }

  public static Color Hazel
  {
    get
    {
      return new Color(0.5568628f, 0.4627451f, 0.09411765f, 1f);
    }
  }

  public static Color MutedPink
  {
    get
    {
      return new Color(0.8196079f, 0.4627451f, 0.5607843f, 1f);
    }
  }

  public static Color BoogerGreen
  {
    get
    {
      return new Color(0.5882353f, 0.7058824f, 0.01176471f, 1f);
    }
  }

  public static Color Canary
  {
    get
    {
      return new Color(0.9921569f, 1f, 0.3882353f, 1f);
    }
  }

  public static Color CoolGrey
  {
    get
    {
      return new Color(0.5843138f, 0.6392157f, 0.6509804f, 1f);
    }
  }

  public static Color DarkTaupe
  {
    get
    {
      return new Color(0.4980392f, 0.4078431f, 0.3058824f, 1f);
    }
  }

  public static Color DarkishPurple
  {
    get
    {
      return new Color(0.4588235f, 0.09803922f, 0.4509804f, 1f);
    }
  }

  public static Color TrueGreen
  {
    get
    {
      return new Color(0.03137255f, 0.5803922f, 0.01568628f, 1f);
    }
  }

  public static Color CoralPink
  {
    get
    {
      return new Color(1f, 0.3803922f, 0.3882353f, 1f);
    }
  }

  public static Color DarkSage
  {
    get
    {
      return new Color(0.3490196f, 0.5215687f, 0.3372549f, 1f);
    }
  }

  public static Color DarkSlateBlue
  {
    get
    {
      return new Color(0.1294118f, 0.2784314f, 0.3803922f, 1f);
    }
  }

  public static Color FlatBlue
  {
    get
    {
      return new Color(0.2352941f, 0.4509804f, 0.6588235f, 1f);
    }
  }

  public static Color Mushroom
  {
    get
    {
      return new Color(0.7294118f, 0.6196079f, 0.5333334f, 1f);
    }
  }

  public static Color RichBlue
  {
    get
    {
      return new Color(0.007843138f, 0.1058824f, 0.9764706f, 1f);
    }
  }

  public static Color DirtyPurple
  {
    get
    {
      return new Color(0.4509804f, 0.2901961f, 0.3960784f, 1f);
    }
  }

  public static Color Greenblue
  {
    get
    {
      return new Color(0.1372549f, 0.7686275f, 0.5450981f, 1f);
    }
  }

  public static Color IckyGreen
  {
    get
    {
      return new Color(0.5607843f, 0.682353f, 0.1333333f, 1f);
    }
  }

  public static Color LightKhaki
  {
    get
    {
      return new Color(0.9019608f, 0.9490196f, 0.6352941f, 1f);
    }
  }

  public static Color WarmBlue
  {
    get
    {
      return new Color(0.2941177f, 0.3411765f, 0.8588235f, 1f);
    }
  }

  public static Color DarkHotPink
  {
    get
    {
      return new Color(0.8509804f, 0.003921569f, 0.4f, 1f);
    }
  }

  public static Color DeepSeaBlue
  {
    get
    {
      return new Color(0.003921569f, 0.3294118f, 0.509804f, 1f);
    }
  }

  public static Color Carmine
  {
    get
    {
      return new Color(0.6156863f, 0.007843138f, 0.08627451f, 1f);
    }
  }

  public static Color DarkYellowGreen
  {
    get
    {
      return new Color(0.4470588f, 0.5607843f, 0.007843138f, 1f);
    }
  }

  public static Color PalePeach
  {
    get
    {
      return new Color(1f, 0.8980392f, 0.6784314f, 1f);
    }
  }

  public static Color PlumPurple
  {
    get
    {
      return new Color(0.3058824f, 0.01960784f, 0.3137255f, 1f);
    }
  }

  public static Color GoldenRod
  {
    get
    {
      return new Color(0.9764706f, 0.7372549f, 0.03137255f, 1f);
    }
  }

  public static Color NeonRed
  {
    get
    {
      return new Color(1f, 0.02745098f, 0.227451f, 1f);
    }
  }

  public static Color OldPink
  {
    get
    {
      return new Color(0.7803922f, 0.4745098f, 0.5254902f, 1f);
    }
  }

  public static Color VeryPaleBlue
  {
    get
    {
      return new Color(0.8392157f, 1f, 0.9960784f, 1f);
    }
  }

  public static Color BloodOrange
  {
    get
    {
      return new Color(0.9960784f, 0.2941177f, 0.01176471f, 1f);
    }
  }

  public static Color Grapefruit
  {
    get
    {
      return new Color(0.9921569f, 0.3490196f, 0.3372549f, 1f);
    }
  }

  public static Color SandYellow
  {
    get
    {
      return new Color(0.9882353f, 0.8823529f, 0.4f, 1f);
    }
  }

  public static Color ClayBrown
  {
    get
    {
      return new Color(0.6980392f, 0.4431373f, 0.2392157f, 1f);
    }
  }

  public static Color DarkBlueGrey
  {
    get
    {
      return new Color(0.1215686f, 0.2313726f, 0.3019608f, 1f);
    }
  }

  public static Color FlatGreen
  {
    get
    {
      return new Color(0.4117647f, 0.6156863f, 0.2980392f, 1f);
    }
  }

  public static Color LightGreenBlue
  {
    get
    {
      return new Color(0.3372549f, 0.9882353f, 0.6352941f, 1f);
    }
  }

  public static Color WarmPink
  {
    get
    {
      return new Color(0.9843137f, 0.3333333f, 0.5058824f, 1f);
    }
  }

  public static Color DodgerBlue
  {
    get
    {
      return new Color(0.2431373f, 0.509804f, 0.9882353f, 1f);
    }
  }

  public static Color GrossGreen
  {
    get
    {
      return new Color(0.627451f, 0.7490196f, 0.08627451f, 1f);
    }
  }

  public static Color Ice
  {
    get
    {
      return new Color(0.8392157f, 1f, 0.9803922f, 1f);
    }
  }

  public static Color MetallicBlue
  {
    get
    {
      return new Color(0.3098039f, 0.4509804f, 0.5568628f, 1f);
    }
  }

  public static Color PaleSalmon
  {
    get
    {
      return new Color(1f, 0.6941177f, 0.6039216f, 1f);
    }
  }

  public static Color SapGreen
  {
    get
    {
      return new Color(0.3607843f, 0.5450981f, 0.08235294f, 1f);
    }
  }

  public static Color Algae
  {
    get
    {
      return new Color(0.3294118f, 0.6745098f, 0.4078431f, 1f);
    }
  }

  public static Color BlueyGrey
  {
    get
    {
      return new Color(0.5372549f, 0.627451f, 0.6901961f, 1f);
    }
  }

  public static Color GreenyGrey
  {
    get
    {
      return new Color(0.4941176f, 0.627451f, 0.4784314f, 1f);
    }
  }

  public static Color HighlighterGreen
  {
    get
    {
      return new Color(0.1058824f, 0.9882353f, 0.02352941f, 1f);
    }
  }

  public static Color LightLightBlue
  {
    get
    {
      return new Color(0.7921569f, 1f, 0.9843137f, 1f);
    }
  }

  public static Color LightMint
  {
    get
    {
      return new Color(0.7137255f, 1f, 0.7333333f, 1f);
    }
  }

  public static Color RawUmber
  {
    get
    {
      return new Color(0.654902f, 0.3686275f, 0.03529412f, 1f);
    }
  }

  public static Color VividBlue
  {
    get
    {
      return new Color(0.08235294f, 0.1803922f, 1f, 1f);
    }
  }

  public static Color DeepLavender
  {
    get
    {
      return new Color(0.5529412f, 0.3686275f, 0.7176471f, 1f);
    }
  }

  public static Color DullTeal
  {
    get
    {
      return new Color(0.372549f, 0.6196079f, 0.5607843f, 1f);
    }
  }

  public static Color LightGreenishBlue
  {
    get
    {
      return new Color(0.3882353f, 0.9686275f, 0.7058824f, 1f);
    }
  }

  public static Color MudGreen
  {
    get
    {
      return new Color(0.3764706f, 0.4f, 0.007843138f, 1f);
    }
  }

  public static Color Pinky
  {
    get
    {
      return new Color(0.9882353f, 0.5254902f, 0.6666667f, 1f);
    }
  }

  public static Color RedWine
  {
    get
    {
      return new Color(0.5490196f, 0.0f, 0.2039216f, 1f);
    }
  }

  public static Color ShitGreen
  {
    get
    {
      return new Color(0.4588235f, 0.5019608f, 0.0f, 1f);
    }
  }

  public static Color TanBrown
  {
    get
    {
      return new Color(0.6705883f, 0.4941176f, 0.2980392f, 1f);
    }
  }

  public static Color Darkblue
  {
    get
    {
      return new Color(0.01176471f, 0.02745098f, 0.3921569f, 1f);
    }
  }

  public static Color Rosa
  {
    get
    {
      return new Color(0.9960784f, 0.5254902f, 0.6431373f, 1f);
    }
  }

  public static Color Lipstick
  {
    get
    {
      return new Color(0.8352941f, 0.09019608f, 0.3058824f, 1f);
    }
  }

  public static Color PaleMauve
  {
    get
    {
      return new Color(0.9960784f, 0.8156863f, 0.9882353f, 1f);
    }
  }

  public static Color Claret
  {
    get
    {
      return new Color(0.4078431f, 0.0f, 0.09411765f, 1f);
    }
  }

  public static Color Dandelion
  {
    get
    {
      return new Color(0.9960784f, 0.8745098f, 0.03137255f, 1f);
    }
  }

  public static Color Orangered
  {
    get
    {
      return new Color(0.9960784f, 0.2588235f, 0.05882353f, 1f);
    }
  }

  public static Color PoopGreen
  {
    get
    {
      return new Color(0.4352941f, 0.4862745f, 0.0f, 1f);
    }
  }

  public static Color Ruby
  {
    get
    {
      return new Color(0.7921569f, 0.003921569f, 0.2784314f, 1f);
    }
  }

  public static Color Dark
  {
    get
    {
      return new Color(0.1058824f, 0.1411765f, 0.1921569f, 1f);
    }
  }

  public static Color GreenishTurquoise
  {
    get
    {
      return new Color(0.0f, 0.9843137f, 0.6901961f, 1f);
    }
  }

  public static Color PastelRed
  {
    get
    {
      return new Color(0.8588235f, 0.345098f, 0.3372549f, 1f);
    }
  }

  public static Color PissYellow
  {
    get
    {
      return new Color(0.8666667f, 0.8392157f, 0.09411765f, 1f);
    }
  }

  public static Color BrightCyan
  {
    get
    {
      return new Color(0.254902f, 0.9921569f, 0.9960784f, 1f);
    }
  }

  public static Color DarkCoral
  {
    get
    {
      return new Color(0.8117647f, 0.3215686f, 0.3058824f, 1f);
    }
  }

  public static Color AlgaeGreen
  {
    get
    {
      return new Color(0.1294118f, 0.7647059f, 0.4352941f, 1f);
    }
  }

  public static Color DarkishRed
  {
    get
    {
      return new Color(0.6627451f, 0.01176471f, 0.03137255f, 1f);
    }
  }

  public static Color ReddyBrown
  {
    get
    {
      return new Color(0.4313726f, 0.0627451f, 0.01960784f, 1f);
    }
  }

  public static Color BlushPink
  {
    get
    {
      return new Color(0.9960784f, 0.509804f, 0.5490196f, 1f);
    }
  }

  public static Color CamouflageGreen
  {
    get
    {
      return new Color(0.2941177f, 0.3803922f, 0.07450981f, 1f);
    }
  }

  public static Color LawnGreen
  {
    get
    {
      return new Color(0.3019608f, 0.6431373f, 0.03529412f, 1f);
    }
  }

  public static Color Putty
  {
    get
    {
      return new Color(0.7450981f, 0.682353f, 0.5411765f, 1f);
    }
  }

  public static Color VibrantBlue
  {
    get
    {
      return new Color(0.01176471f, 0.2235294f, 0.972549f, 1f);
    }
  }

  public static Color DarkSand
  {
    get
    {
      return new Color(0.6588235f, 0.5607843f, 0.3490196f, 1f);
    }
  }

  public static Color Purple_Blue
  {
    get
    {
      return new Color(0.3647059f, 0.1294118f, 0.8156863f, 1f);
    }
  }

  public static Color Saffron
  {
    get
    {
      return new Color(0.9960784f, 0.6980392f, 0.03529412f, 1f);
    }
  }

  public static Color Twilight
  {
    get
    {
      return new Color(0.3058824f, 0.3176471f, 0.5450981f, 1f);
    }
  }

  public static Color WarmBrown
  {
    get
    {
      return new Color(0.5882353f, 0.3058824f, 0.007843138f, 1f);
    }
  }

  public static Color Bluegrey
  {
    get
    {
      return new Color(0.5215687f, 0.6392157f, 0.6980392f, 1f);
    }
  }

  public static Color BubbleGumPink
  {
    get
    {
      return new Color(1f, 0.4117647f, 0.6862745f, 1f);
    }
  }

  public static Color DuckEggBlue
  {
    get
    {
      return new Color(0.7647059f, 0.9843137f, 0.9568627f, 1f);
    }
  }

  public static Color GreenishCyan
  {
    get
    {
      return new Color(0.1647059f, 0.9960784f, 0.7176471f, 1f);
    }
  }

  public static Color Petrol
  {
    get
    {
      return new Color(0.0f, 0.372549f, 0.4156863f, 1f);
    }
  }

  public static Color Royal
  {
    get
    {
      return new Color(0.04705882f, 0.09019608f, 0.5764706f, 1f);
    }
  }

  public static Color Butter
  {
    get
    {
      return new Color(1f, 1f, 0.5058824f, 1f);
    }
  }

  public static Color DustyOrange
  {
    get
    {
      return new Color(0.9411765f, 0.5137255f, 0.227451f, 1f);
    }
  }

  public static Color OffYellow
  {
    get
    {
      return new Color(0.945098f, 0.9529412f, 0.2470588f, 1f);
    }
  }

  public static Color PaleOliveGreen
  {
    get
    {
      return new Color(0.6941177f, 0.8235294f, 0.4823529f, 1f);
    }
  }

  public static Color Orangish
  {
    get
    {
      return new Color(0.9882353f, 0.509804f, 0.2901961f, 1f);
    }
  }

  public static Color Leaf
  {
    get
    {
      return new Color(0.4431373f, 0.6666667f, 0.2039216f, 1f);
    }
  }

  public static Color LightBlueGrey
  {
    get
    {
      return new Color(0.7176471f, 0.7882353f, 0.8862745f, 1f);
    }
  }

  public static Color DriedBlood
  {
    get
    {
      return new Color(0.2941177f, 0.003921569f, 0.003921569f, 1f);
    }
  }

  public static Color LightishPurple
  {
    get
    {
      return new Color(0.6470588f, 0.3215686f, 0.9019608f, 1f);
    }
  }

  public static Color RustyRed
  {
    get
    {
      return new Color(0.6862745f, 0.1843137f, 0.05098039f, 1f);
    }
  }

  public static Color LavenderBlue
  {
    get
    {
      return new Color(0.5450981f, 0.5333334f, 0.972549f, 1f);
    }
  }

  public static Color LightGrassGreen
  {
    get
    {
      return new Color(0.6039216f, 0.9686275f, 0.3921569f, 1f);
    }
  }

  public static Color LightMintGreen
  {
    get
    {
      return new Color(0.6509804f, 0.9843137f, 0.6980392f, 1f);
    }
  }

  public static Color Sunflower
  {
    get
    {
      return new Color(1f, 0.772549f, 0.07058824f, 1f);
    }
  }

  public static Color Velvet
  {
    get
    {
      return new Color(0.4588235f, 0.03137255f, 0.3176471f, 1f);
    }
  }

  public static Color BrickOrange
  {
    get
    {
      return new Color(0.7568628f, 0.2901961f, 0.03529412f, 1f);
    }
  }

  public static Color LightishRed
  {
    get
    {
      return new Color(0.9960784f, 0.1843137f, 0.2901961f, 1f);
    }
  }

  public static Color PureBlue
  {
    get
    {
      return new Color(0.007843138f, 0.01176471f, 0.8862745f, 1f);
    }
  }

  public static Color TwilightBlue
  {
    get
    {
      return new Color(0.03921569f, 0.2627451f, 0.4784314f, 1f);
    }
  }

  public static Color VioletRed
  {
    get
    {
      return new Color(0.6470588f, 0.0f, 0.3333333f, 1f);
    }
  }

  public static Color YellowyBrown
  {
    get
    {
      return new Color(0.682353f, 0.5450981f, 0.04705882f, 1f);
    }
  }

  public static Color Carnation
  {
    get
    {
      return new Color(0.9921569f, 0.4745098f, 0.5607843f, 1f);
    }
  }

  public static Color MuddyYellow
  {
    get
    {
      return new Color(0.7490196f, 0.6745098f, 0.01960784f, 1f);
    }
  }

  public static Color DarkSeafoamGreen
  {
    get
    {
      return new Color(0.2431373f, 0.6862745f, 0.4627451f, 1f);
    }
  }

  public static Color DeepRose
  {
    get
    {
      return new Color(0.7803922f, 0.2784314f, 0.4039216f, 1f);
    }
  }

  public static Color DustyRed
  {
    get
    {
      return new Color(0.7254902f, 0.282353f, 0.3058824f, 1f);
    }
  }

  public static Color Grey_Blue
  {
    get
    {
      return new Color(0.3921569f, 0.4901961f, 0.5568628f, 1f);
    }
  }

  public static Color LemonLime
  {
    get
    {
      return new Color(0.7490196f, 0.9960784f, 0.1568628f, 1f);
    }
  }

  public static Color Purple_Pink
  {
    get
    {
      return new Color(0.8431373f, 0.145098f, 0.8705882f, 1f);
    }
  }

  public static Color BrownYellow
  {
    get
    {
      return new Color(0.6980392f, 0.5921569f, 0.01960784f, 1f);
    }
  }

  public static Color PurpleBrown
  {
    get
    {
      return new Color(0.4039216f, 0.227451f, 0.2470588f, 1f);
    }
  }

  public static Color Wisteria
  {
    get
    {
      return new Color(0.6588235f, 0.4901961f, 0.7607843f, 1f);
    }
  }

  public static Color BananaYellow
  {
    get
    {
      return new Color(0.9803922f, 0.9960784f, 0.2941177f, 1f);
    }
  }

  public static Color LipstickRed
  {
    get
    {
      return new Color(0.7529412f, 0.007843138f, 0.1843137f, 1f);
    }
  }

  public static Color WaterBlue
  {
    get
    {
      return new Color(0.05490196f, 0.5294118f, 0.8f, 1f);
    }
  }

  public static Color BrownGrey
  {
    get
    {
      return new Color(0.5529412f, 0.5176471f, 0.4078431f, 1f);
    }
  }

  public static Color VibrantPurple
  {
    get
    {
      return new Color(0.6784314f, 0.01176471f, 0.8705882f, 1f);
    }
  }

  public static Color BabyGreen
  {
    get
    {
      return new Color(0.5490196f, 1f, 0.6196079f, 1f);
    }
  }

  public static Color BarfGreen
  {
    get
    {
      return new Color(0.5803922f, 0.6745098f, 0.007843138f, 1f);
    }
  }

  public static Color EggshellBlue
  {
    get
    {
      return new Color(0.7686275f, 1f, 0.9686275f, 1f);
    }
  }

  public static Color SandyYellow
  {
    get
    {
      return new Color(0.9921569f, 0.9333333f, 0.4509804f, 1f);
    }
  }

  public static Color CoolGreen
  {
    get
    {
      return new Color(0.2f, 0.7215686f, 0.3921569f, 1f);
    }
  }

  public static Color Pale
  {
    get
    {
      return new Color(1f, 0.9764706f, 0.8156863f, 1f);
    }
  }

  public static Color Blue_Grey
  {
    get
    {
      return new Color(0.4588235f, 0.5529412f, 0.6392157f, 1f);
    }
  }

  public static Color HotMagenta
  {
    get
    {
      return new Color(0.9607843f, 0.01568628f, 0.7882353f, 1f);
    }
  }

  public static Color Greyblue
  {
    get
    {
      return new Color(0.4666667f, 0.6313726f, 0.7098039f, 1f);
    }
  }

  public static Color Purpley
  {
    get
    {
      return new Color(0.5294118f, 0.3372549f, 0.8941177f, 1f);
    }
  }

  public static Color BabyShitGreen
  {
    get
    {
      return new Color(0.5333334f, 0.5921569f, 0.09019608f, 1f);
    }
  }

  public static Color BrownishPink
  {
    get
    {
      return new Color(0.7607843f, 0.4941176f, 0.4745098f, 1f);
    }
  }

  public static Color DarkAquamarine
  {
    get
    {
      return new Color(0.003921569f, 0.4509804f, 0.4431373f, 1f);
    }
  }

  public static Color Diarrhea
  {
    get
    {
      return new Color(0.6235294f, 0.5137255f, 0.01176471f, 1f);
    }
  }

  public static Color LightMustard
  {
    get
    {
      return new Color(0.9686275f, 0.8352941f, 0.3764706f, 1f);
    }
  }

  public static Color PaleSkyBlue
  {
    get
    {
      return new Color(0.7411765f, 0.9647059f, 0.9960784f, 1f);
    }
  }

  public static Color TurtleGreen
  {
    get
    {
      return new Color(0.4588235f, 0.7215686f, 0.3098039f, 1f);
    }
  }

  public static Color BrightOlive
  {
    get
    {
      return new Color(0.6117647f, 0.7333333f, 0.01568628f, 1f);
    }
  }

  public static Color DarkGreyBlue
  {
    get
    {
      return new Color(0.1607843f, 0.2745098f, 0.3568628f, 1f);
    }
  }

  public static Color GreenyBrown
  {
    get
    {
      return new Color(0.4117647f, 0.3764706f, 0.02352941f, 1f);
    }
  }

  public static Color LemonGreen
  {
    get
    {
      return new Color(0.6784314f, 0.972549f, 0.007843138f, 1f);
    }
  }

  public static Color LightPeriwinkle
  {
    get
    {
      return new Color(0.7568628f, 0.7764706f, 0.9882353f, 1f);
    }
  }

  public static Color SeaweedGreen
  {
    get
    {
      return new Color(0.2078431f, 0.6784314f, 0.4196078f, 1f);
    }
  }

  public static Color SunshineYellow
  {
    get
    {
      return new Color(1f, 0.9921569f, 68.0f * (float)Math.E / 857.0f, 1f);
    }
  }

  public static Color UglyPurple
  {
    get
    {
      return new Color(0.6431373f, 0.2588235f, 0.627451f, 1f);
    }
  }

  public static Color MediumPink
  {
    get
    {
      return new Color(0.9529412f, 0.3803922f, 0.5882353f, 1f);
    }
  }

  public static Color PukeBrown
  {
    get
    {
      return new Color(0.5803922f, 0.4666667f, 0.02352941f, 1f);
    }
  }

  public static Color VeryLightPink
  {
    get
    {
      return new Color(1f, 0.9568627f, 0.9490196f, 1f);
    }
  }

  public static Color Viridian
  {
    get
    {
      return new Color(0.1176471f, 0.5686275f, 0.4039216f, 1f);
    }
  }

  public static Color Bile
  {
    get
    {
      return new Color(0.7098039f, 0.7647059f, 0.02352941f, 1f);
    }
  }

  public static Color FadedYellow
  {
    get
    {
      return new Color(0.9960784f, 1f, 0.4980392f, 1f);
    }
  }

  public static Color VeryPaleGreen
  {
    get
    {
      return new Color(0.8117647f, 0.9921569f, 0.7372549f, 1f);
    }
  }

  public static Color VibrantGreen
  {
    get
    {
      return new Color(0.03921569f, 0.8666667f, 0.03137255f, 1f);
    }
  }

  public static Color BrightLime
  {
    get
    {
      return new Color(0.5294118f, 0.9921569f, 0.01960784f, 1f);
    }
  }

  public static Color Spearmint
  {
    get
    {
      return new Color(0.1176471f, 0.972549f, 0.4627451f, 1f);
    }
  }

  public static Color LightAquamarine
  {
    get
    {
      return new Color(0.4823529f, 0.9921569f, 0.7803922f, 1f);
    }
  }

  public static Color LightSage
  {
    get
    {
      return new Color(0.7372549f, 0.9254902f, 0.6745098f, 1f);
    }
  }

  public static Color Yellowgreen
  {
    get
    {
      return new Color(0.7333333f, 0.9764706f, 0.05882353f, 1f);
    }
  }

  public static Color BabyPoo
  {
    get
    {
      return new Color(0.6705883f, 0.5647059f, 0.01568628f, 1f);
    }
  }

  public static Color DarkSeafoam
  {
    get
    {
      return new Color(0.1215686f, 0.7098039f, 0.4784314f, 1f);
    }
  }

  public static Color DeepTeal
  {
    get
    {
      return new Color(0.0f, 0.3333333f, 0.3529412f, 1f);
    }
  }

  public static Color Heather
  {
    get
    {
      return new Color(0.6431373f, 0.5176471f, 0.6745098f, 1f);
    }
  }

  public static Color RustOrange
  {
    get
    {
      return new Color(0.7686275f, 0.3333333f, 0.03137255f, 1f);
    }
  }

  public static Color DirtyBlue
  {
    get
    {
      return new Color(0.2470588f, 0.509804f, 0.6156863f, 1f);
    }
  }

  public static Color FernGreen
  {
    get
    {
      return new Color(0.3294118f, 0.5529412f, 0.2666667f, 1f);
    }
  }

  public static Color BrightLilac
  {
    get
    {
      return new Color(0.7882353f, 0.3686275f, 0.9843137f, 1f);
    }
  }

  public static Color WeirdGreen
  {
    get
    {
      return new Color(0.227451f, 0.8980392f, 0.4980392f, 1f);
    }
  }

  public static Color PeacockBlue
  {
    get
    {
      return new Color(0.003921569f, 0.4039216f, 0.5843138f, 1f);
    }
  }

  public static Color AvocadoGreen
  {
    get
    {
      return new Color(0.5294118f, 0.6627451f, 0.1333333f, 1f);
    }
  }

  public static Color FadedOrange
  {
    get
    {
      return new Color(0.9411765f, 0.5803922f, 0.3019608f, 1f);
    }
  }

  public static Color GrapePurple
  {
    get
    {
      return new Color(0.3647059f, 0.07843138f, 0.3176471f, 1f);
    }
  }

  public static Color HotGreen
  {
    get
    {
      return new Color(0.145098f, 1f, 0.1607843f, 1f);
    }
  }

  public static Color LimeYellow
  {
    get
    {
      return new Color(0.8156863f, 0.9960784f, 0.1137255f, 1f);
    }
  }

  public static Color Mango
  {
    get
    {
      return new Color(1f, 0.6509804f, 0.1686275f, 1f);
    }
  }

  public static Color Shamrock
  {
    get
    {
      return new Color(0.003921569f, 0.7058824f, 0.2980392f, 1f);
    }
  }

  public static Color Bubblegum
  {
    get
    {
      return new Color(1f, 0.4235294f, 0.7098039f, 1f);
    }
  }

  public static Color PurplishBrown
  {
    get
    {
      return new Color(0.4196078f, 0.2588235f, 0.2784314f, 1f);
    }
  }

  public static Color VomitYellow
  {
    get
    {
      return new Color(0.7803922f, 0.7568628f, 0.04705882f, 1f);
    }
  }

  public static Color PaleCyan
  {
    get
    {
      return new Color(0.7176471f, 1f, 0.9803922f, 1f);
    }
  }

  public static Color KeyLime
  {
    get
    {
      return new Color(0.682353f, 1f, 0.4313726f, 1f);
    }
  }

  public static Color TomatoRed
  {
    get
    {
      return new Color(0.9254902f, 0.1764706f, 0.003921569f, 1f);
    }
  }

  public static Color Lightgreen
  {
    get
    {
      return new Color(0.4627451f, 1f, 0.4823529f, 1f);
    }
  }

  public static Color Merlot
  {
    get
    {
      return new Color(0.4509804f, 0.0f, 0.2235294f, 1f);
    }
  }

  public static Color NightBlue
  {
    get
    {
      return new Color(0.01568628f, 0.01176471f, 0.282353f, 1f);
    }
  }

  public static Color PurpleishPink
  {
    get
    {
      return new Color(0.8745098f, 0.3058824f, 0.7843137f, 1f);
    }
  }

  public static Color Apple
  {
    get
    {
      return new Color(0.4313726f, 0.7960784f, 0.2352941f, 1f);
    }
  }

  public static Color BabyPoopGreen
  {
    get
    {
      return new Color(0.5607843f, 0.5960785f, 0.01960784f, 1f);
    }
  }

  public static Color GreenApple
  {
    get
    {
      return new Color(0.3686275f, 0.8627451f, 0.1215686f, 1f);
    }
  }

  public static Color Heliotrope
  {
    get
    {
      return new Color(0.8509804f, 0.3098039f, 0.9607843f, 1f);
    }
  }

  public static Color Yellow_Green
  {
    get
    {
      return new Color(0.7843137f, 0.9921569f, 0.2392157f, 1f);
    }
  }

  public static Color AlmostBlack
  {
    get
    {
      return new Color(0.02745098f, 0.05098039f, 0.05098039f, 1f);
    }
  }

  public static Color CoolBlue
  {
    get
    {
      return new Color(0.2862745f, 0.5176471f, 0.7215686f, 1f);
    }
  }

  public static Color LeafyGreen
  {
    get
    {
      return new Color(0.3176471f, 0.7176471f, 0.2313726f, 1f);
    }
  }

  public static Color MustardBrown
  {
    get
    {
      return new Color(0.6745098f, 0.4941176f, 0.01568628f, 1f);
    }
  }

  public static Color Dusk
  {
    get
    {
      return new Color(0.3058824f, 0.3294118f, 0.5058824f, 1f);
    }
  }

  public static Color DullBrown
  {
    get
    {
      return new Color(0.5294118f, 0.4313726f, 0.2941177f, 1f);
    }
  }

  public static Color FrogGreen
  {
    get
    {
      return new Color(0.345098f, 0.7372549f, 0.03137255f, 1f);
    }
  }

  public static Color VividGreen
  {
    get
    {
      return new Color(0.1843137f, 0.9372549f, 0.0627451f, 1f);
    }
  }

  public static Color BrightLightGreen
  {
    get
    {
      return new Color(0.1764706f, 0.9960784f, 0.3294118f, 1f);
    }
  }

  public static Color FluroGreen
  {
    get
    {
      return new Color(0.03921569f, 1f, 0.007843138f, 1f);
    }
  }

  public static Color Kiwi
  {
    get
    {
      return new Color(0.6117647f, 0.9372549f, 0.2627451f, 1f);
    }
  }

  public static Color Seaweed
  {
    get
    {
      return new Color(0.09411765f, 0.8196079f, 0.4823529f, 1f);
    }
  }

  public static Color NavyGreen
  {
    get
    {
      return new Color(0.2078431f, 0.3254902f, 0.03921569f, 1f);
    }
  }

  public static Color UltramarineBlue
  {
    get
    {
      return new Color(0.09411765f, 0.01960784f, 0.8588235f, 1f);
    }
  }

  public static Color Iris
  {
    get
    {
      return new Color(0.3843137f, 0.345098f, 0.7686275f, 1f);
    }
  }

  public static Color PastelOrange
  {
    get
    {
      return new Color(1f, 0.5882353f, 0.3098039f, 1f);
    }
  }

  public static Color YellowishOrange
  {
    get
    {
      return new Color(1f, 0.6705883f, 0.05882353f, 1f);
    }
  }

  public static Color Perrywinkle
  {
    get
    {
      return new Color(0.5607843f, 0.5490196f, 0.9058824f, 1f);
    }
  }

  public static Color Tealish
  {
    get
    {
      return new Color(0.1411765f, 0.7372549f, 0.6588235f, 1f);
    }
  }

  public static Color DarkPlum
  {
    get
    {
      return new Color(0.2470588f, 0.003921569f, 0.172549f, 1f);
    }
  }

  public static Color Pear
  {
    get
    {
      return new Color(0.7960784f, 0.972549f, 0.372549f, 1f);
    }
  }

  public static Color PinkishOrange
  {
    get
    {
      return new Color(1f, 0.4470588f, 0.2980392f, 1f);
    }
  }

  public static Color MidnightPurple
  {
    get
    {
      return new Color(0.1568628f, 0.003921569f, 68.0f * (float)Math.E / 857.0f, 1f);
    }
  }

  public static Color LightUrple
  {
    get
    {
      return new Color(0.7019608f, 0.4352941f, 0.9647059f, 1f);
    }
  }

  public static Color DarkMint
  {
    get
    {
      return new Color(0.282353f, 0.7529412f, 0.4470588f, 1f);
    }
  }

  public static Color GreenishTan
  {
    get
    {
      return new Color(0.7372549f, 0.7960784f, 0.4784314f, 1f);
    }
  }

  public static Color LightBurgundy
  {
    get
    {
      return new Color(0.6588235f, 0.254902f, 0.3568628f, 1f);
    }
  }

  public static Color TurquoiseBlue
  {
    get
    {
      return new Color(0.02352941f, 0.6941177f, 0.7686275f, 1f);
    }
  }

  public static Color UglyPink
  {
    get
    {
      return new Color(0.8039216f, 0.4588235f, 0.5176471f, 1f);
    }
  }

  public static Color Sandy
  {
    get
    {
      return new Color(0.945098f, 0.854902f, 0.4784314f, 1f);
    }
  }

  public static Color ElectricPink
  {
    get
    {
      return new Color(1f, 0.01568628f, 0.5647059f, 1f);
    }
  }

  public static Color MutedPurple
  {
    get
    {
      return new Color(0.5019608f, 0.3568628f, 0.5294118f, 1f);
    }
  }

  public static Color MidGreen
  {
    get
    {
      return new Color(0.3137255f, 0.654902f, 0.2784314f, 1f);
    }
  }

  public static Color Greyish
  {
    get
    {
      return new Color(0.6588235f, 0.6431373f, 0.5843138f, 1f);
    }
  }

  public static Color NeonYellow
  {
    get
    {
      return new Color(0.8117647f, 1f, 0.01568628f, 1f);
    }
  }

  public static Color Banana
  {
    get
    {
      return new Color(1f, 1f, 0.4941176f, 1f);
    }
  }

  public static Color CarnationPink
  {
    get
    {
      return new Color(1f, 0.4980392f, 0.654902f, 1f);
    }
  }

  public static Color Tomato
  {
    get
    {
      return new Color(0.9372549f, 0.2509804f, 0.1490196f, 1f);
    }
  }

  public static Color Sea
  {
    get
    {
      return new Color(0.2352941f, 0.6f, 0.572549f, 1f);
    }
  }

  public static Color MuddyBrown
  {
    get
    {
      return new Color(0.5333334f, 0.4078431f, 0.02352941f, 1f);
    }
  }

  public static Color TurquoiseGreen
  {
    get
    {
      return new Color(0.01568628f, 0.9568627f, 0.5372549f, 1f);
    }
  }

  public static Color Buff
  {
    get
    {
      return new Color(0.9960784f, 0.9647059f, 0.6196079f, 1f);
    }
  }

  public static Color Fawn
  {
    get
    {
      return new Color(0.8117647f, 0.6862745f, 0.4823529f, 1f);
    }
  }

  public static Color MutedBlue
  {
    get
    {
      return new Color(0.2313726f, 0.4431373f, 0.6235294f, 1f);
    }
  }

  public static Color PaleRose
  {
    get
    {
      return new Color(0.9921569f, 0.7568628f, 0.772549f, 1f);
    }
  }

  public static Color DarkMintGreen
  {
    get
    {
      return new Color(0.1254902f, 0.7529412f, 0.4509804f, 1f);
    }
  }

  public static Color Amethyst
  {
    get
    {
      return new Color(0.6078432f, 0.372549f, 0.7529412f, 1f);
    }
  }

  public static Color Blue_Green
  {
    get
    {
      return new Color(0.05882353f, 0.6078432f, 0.5568628f, 1f);
    }
  }

  public static Color Chestnut
  {
    get
    {
      return new Color(0.454902f, 0.1568628f, 0.007843138f, 1f);
    }
  }

  public static Color SickGreen
  {
    get
    {
      return new Color(0.6156863f, 0.7254902f, 0.172549f, 1f);
    }
  }

  public static Color Pea
  {
    get
    {
      return new Color(0.6431373f, 0.7490196f, 0.1254902f, 1f);
    }
  }

  public static Color RustyOrange
  {
    get
    {
      return new Color(0.8039216f, 0.3490196f, 0.03529412f, 1f);
    }
  }

  public static Color Stone
  {
    get
    {
      return new Color(0.6784314f, 0.6470588f, 0.5294118f, 1f);
    }
  }

  public static Color RoseRed
  {
    get
    {
      return new Color(0.7450981f, 0.003921569f, 0.2352941f, 1f);
    }
  }

  public static Color PaleAqua
  {
    get
    {
      return new Color(0.7215686f, 1f, 0.9215686f, 1f);
    }
  }

  public static Color DeepOrange
  {
    get
    {
      return new Color(0.8627451f, 0.3019608f, 0.003921569f, 1f);
    }
  }

  public static Color Earth
  {
    get
    {
      return new Color(0.6352941f, 0.3960784f, 0.2431373f, 1f);
    }
  }

  public static Color MossyGreen
  {
    get
    {
      return new Color(0.3882353f, 0.5450981f, 0.1529412f, 1f);
    }
  }

  public static Color GrassyGreen
  {
    get
    {
      return new Color(0.254902f, 0.6117647f, 0.01176471f, 1f);
    }
  }

  public static Color PaleLimeGreen
  {
    get
    {
      return new Color(0.6941177f, 1f, 0.3960784f, 1f);
    }
  }

  public static Color LightGreyBlue
  {
    get
    {
      return new Color(0.6156863f, 0.7372549f, 0.8313726f, 1f);
    }
  }

  public static Color PaleGrey
  {
    get
    {
      return new Color(0.9921569f, 0.9921569f, 0.9960784f, 1f);
    }
  }

  public static Color Asparagus
  {
    get
    {
      return new Color(0.4666667f, 0.6705883f, 0.3372549f, 1f);
    }
  }

  public static Color Blueberry
  {
    get
    {
      return new Color(0.2745098f, 0.254902f, 0.5882353f, 1f);
    }
  }

  public static Color PurpleRed
  {
    get
    {
      return new Color(0.6f, 0.003921569f, 0.2784314f, 1f);
    }
  }

  public static Color PaleLime
  {
    get
    {
      return new Color(0.7450981f, 0.9921569f, 0.4509804f, 1f);
    }
  }

  public static Color GreenishTeal
  {
    get
    {
      return new Color(0.1960784f, 0.7490196f, 0.5176471f, 1f);
    }
  }

  public static Color Caramel
  {
    get
    {
      return new Color(0.6862745f, 0.4352941f, 0.03529412f, 1f);
    }
  }

  public static Color DeepMagenta
  {
    get
    {
      return new Color(0.627451f, 0.007843138f, 0.3607843f, 1f);
    }
  }

  public static Color LightPeach
  {
    get
    {
      return new Color(1f, 0.8470588f, 0.6941177f, 1f);
    }
  }

  public static Color MilkChocolate
  {
    get
    {
      return new Color(0.4980392f, 0.3058824f, 0.1176471f, 1f);
    }
  }

  public static Color Ocher
  {
    get
    {
      return new Color(0.7490196f, 0.6078432f, 0.04705882f, 1f);
    }
  }

  public static Color OffGreen
  {
    get
    {
      return new Color(0.4196078f, 0.6392157f, 0.3254902f, 1f);
    }
  }

  public static Color PurplyPink
  {
    get
    {
      return new Color(0.9411765f, 0.4588235f, 0.9019608f, 1f);
    }
  }

  public static Color Lightblue
  {
    get
    {
      return new Color(0.4823529f, 0.7843137f, 0.9647059f, 1f);
    }
  }

  public static Color DuskyBlue
  {
    get
    {
      return new Color(0.2784314f, 0.372549f, 0.5803922f, 1f);
    }
  }

  public static Color Golden
  {
    get
    {
      return new Color(0.9607843f, 0.7490196f, 0.01176471f, 1f);
    }
  }

  public static Color LightBeige
  {
    get
    {
      return new Color(1f, 0.9960784f, 0.7137255f, 1f);
    }
  }

  public static Color ButterYellow
  {
    get
    {
      return new Color(1f, 0.9921569f, 0.454902f, 1f);
    }
  }

  public static Color DuskyPurple
  {
    get
    {
      return new Color(0.5372549f, 0.3568628f, 0.4823529f, 1f);
    }
  }

  public static Color FrenchBlue
  {
    get
    {
      return new Color(0.2627451f, 0.4196078f, 0.6784314f, 1f);
    }
  }

  public static Color UglyYellow
  {
    get
    {
      return new Color(0.8156863f, 0.7568628f, 0.003921569f, 1f);
    }
  }

  public static Color GreenyYellow
  {
    get
    {
      return new Color(0.7764706f, 0.972549f, 0.03137255f, 1f);
    }
  }

  public static Color OrangishRed
  {
    get
    {
      return new Color(0.9568627f, 0.2117647f, 0.01960784f, 1f);
    }
  }

  public static Color ShamrockGreen
  {
    get
    {
      return new Color(0.007843138f, 0.7568628f, 0.3019608f, 1f);
    }
  }

  public static Color OrangishBrown
  {
    get
    {
      return new Color(0.6980392f, 0.372549f, 0.01176471f, 1f);
    }
  }

  public static Color TreeGreen
  {
    get
    {
      return new Color(0.1647059f, 0.4941176f, 0.09803922f, 1f);
    }
  }

  public static Color DeepViolet
  {
    get
    {
      return new Color(0.2862745f, 0.02352941f, 0.282353f, 1f);
    }
  }

  public static Color Gunmetal
  {
    get
    {
      return new Color(0.3254902f, 0.3843137f, 0.4039216f, 1f);
    }
  }

  public static Color Blue_Purple
  {
    get
    {
      return new Color(0.3529412f, 0.02352941f, 0.9372549f, 1f);
    }
  }

  public static Color Cherry
  {
    get
    {
      return new Color(0.8117647f, 0.007843138f, 0.2039216f, 1f);
    }
  }

  public static Color SandyBrown
  {
    get
    {
      return new Color(0.7686275f, 0.6509804f, 0.3803922f, 1f);
    }
  }

  public static Color WarmGrey
  {
    get
    {
      return new Color(0.5921569f, 0.5411765f, 0.5176471f, 1f);
    }
  }

  public static Color DarkIndigo
  {
    get
    {
      return new Color(0.1215686f, 0.03529412f, 0.3294118f, 1f);
    }
  }

  public static Color Midnight
  {
    get
    {
      return new Color(0.01176471f, 0.003921569f, 0.1764706f, 1f);
    }
  }

  public static Color BlueyGreen
  {
    get
    {
      return new Color(0.1686275f, 0.6941177f, 0.4745098f, 1f);
    }
  }

  public static Color GreyPink
  {
    get
    {
      return new Color(0.7647059f, 0.5647059f, 0.6078432f, 1f);
    }
  }

  public static Color SoftPurple
  {
    get
    {
      return new Color(0.6509804f, 0.4352941f, 0.7098039f, 1f);
    }
  }

  public static Color Blood
  {
    get
    {
      return new Color(0.4666667f, 0.0f, 0.003921569f, 1f);
    }
  }

  public static Color BrownRed
  {
    get
    {
      return new Color(0.572549f, 0.1686275f, 0.01960784f, 1f);
    }
  }

  public static Color MediumGrey
  {
    get
    {
      return new Color(0.4901961f, 0.4980392f, 0.4862745f, 1f);
    }
  }

  public static Color Berry
  {
    get
    {
      return new Color(0.6f, 0.05882353f, 0.2941177f, 1f);
    }
  }

  public static Color Poo
  {
    get
    {
      return new Color(0.5607843f, 0.4509804f, 0.01176471f, 1f);
    }
  }

  public static Color PurpleyPink
  {
    get
    {
      return new Color(0.7843137f, 0.2352941f, 0.7254902f, 1f);
    }
  }

  public static Color LightSalmon
  {
    get
    {
      return new Color(0.9960784f, 0.6627451f, 0.5764706f, 1f);
    }
  }

  public static Color Snot
  {
    get
    {
      return new Color(0.6745098f, 0.7333333f, 0.05098039f, 1f);
    }
  }

  public static Color EasterPurple
  {
    get
    {
      return new Color(0.7529412f, 0.4431373f, 0.9960784f, 1f);
    }
  }

  public static Color LightYellowGreen
  {
    get
    {
      return new Color(0.8f, 0.9921569f, 0.4980392f, 1f);
    }
  }

  public static Color DarkNavyBlue
  {
    get
    {
      return new Color(0.0f, 0.007843138f, 0.1803922f, 1f);
    }
  }

  public static Color Drab
  {
    get
    {
      return new Color(0.509804f, 0.5137255f, 0.2666667f, 1f);
    }
  }

  public static Color LightRose
  {
    get
    {
      return new Color(1f, 0.772549f, 0.7960784f, 1f);
    }
  }

  public static Color Rouge
  {
    get
    {
      return new Color(0.6705883f, 0.07058824f, 0.2235294f, 1f);
    }
  }

  public static Color PurplishRed
  {
    get
    {
      return new Color(0.6901961f, 0.01960784f, 0.2941177f, 1f);
    }
  }

  public static Color SlimeGreen
  {
    get
    {
      return new Color(0.6f, 0.8f, 0.01568628f, 1f);
    }
  }

  public static Color BabyPoop
  {
    get
    {
      return new Color(0.5764706f, 0.4862745f, 0.0f, 1f);
    }
  }

  public static Color IrishGreen
  {
    get
    {
      return new Color(0.003921569f, 0.5843138f, 0.1607843f, 1f);
    }
  }

  public static Color Pink_Purple
  {
    get
    {
      return new Color(0.9372549f, 0.1137255f, 0.9058824f, 1f);
    }
  }

  public static Color DarkNavy
  {
    get
    {
      return new Color(0.0f, 0.01568628f, 0.2078431f, 1f);
    }
  }

  public static Color GreenyBlue
  {
    get
    {
      return new Color(0.2588235f, 0.7019608f, 0.5843138f, 1f);
    }
  }

  public static Color LightPlum
  {
    get
    {
      return new Color(0.6156863f, 0.3411765f, 0.5137255f, 1f);
    }
  }

  public static Color PinkishGrey
  {
    get
    {
      return new Color(0.7843137f, 0.6745098f, 0.6627451f, 1f);
    }
  }

  public static Color DirtyOrange
  {
    get
    {
      return new Color(0.7843137f, 0.4627451f, 0.02352941f, 1f);
    }
  }

  public static Color RustRed
  {
    get
    {
      return new Color(0.6666667f, 0.1529412f, 0.01568628f, 1f);
    }
  }

  public static Color PaleLilac
  {
    get
    {
      return new Color(0.8941177f, 0.7960784f, 1f, 1f);
    }
  }

  public static Color OrangeyRed
  {
    get
    {
      return new Color(0.9803922f, 0.2588235f, 0.1411765f, 1f);
    }
  }

  public static Color PrimaryBlue
  {
    get
    {
      return new Color(0.03137255f, 0.01568628f, 0.9764706f, 1f);
    }
  }

  public static Color KermitGreen
  {
    get
    {
      return new Color(0.3607843f, 0.6980392f, 0.0f, 1f);
    }
  }

  public static Color BrownishPurple
  {
    get
    {
      return new Color(0.4627451f, 0.2588235f, 0.3058824f, 1f);
    }
  }

  public static Color MurkyGreen
  {
    get
    {
      return new Color(0.4235294f, 0.4784314f, 0.05490196f, 1f);
    }
  }

  public static Color Wheat
  {
    get
    {
      return new Color(0.9843137f, 0.8666667f, 0.4941176f, 1f);
    }
  }

  public static Color VeryDarkPurple
  {
    get
    {
      return new Color(0.1647059f, 0.003921569f, 0.2039216f, 1f);
    }
  }

  public static Color BottleGreen
  {
    get
    {
      return new Color(0.01568628f, 0.2901961f, 0.01960784f, 1f);
    }
  }

  public static Color Watermelon
  {
    get
    {
      return new Color(0.9921569f, 0.2745098f, 0.3490196f, 1f);
    }
  }

  public static Color DeepSkyBlue
  {
    get
    {
      return new Color(0.05098039f, 0.4588235f, 0.972549f, 1f);
    }
  }

  public static Color FireEngineRed
  {
    get
    {
      return new Color(0.9960784f, 0.0f, 0.007843138f, 1f);
    }
  }

  public static Color YellowOchre
  {
    get
    {
      return new Color(0.7960784f, 0.6156863f, 0.02352941f, 1f);
    }
  }

  public static Color PumpkinOrange
  {
    get
    {
      return new Color(0.9843137f, 0.4901961f, 0.02745098f, 1f);
    }
  }

  public static Color PaleOlive
  {
    get
    {
      return new Color(0.7254902f, 0.8f, 0.5058824f, 1f);
    }
  }

  public static Color LightLilac
  {
    get
    {
      return new Color(0.9294118f, 0.7843137f, 1f, 1f);
    }
  }

  public static Color LightishGreen
  {
    get
    {
      return new Color(0.3803922f, 0.8823529f, 0.3764706f, 1f);
    }
  }

  public static Color CarolinaBlue
  {
    get
    {
      return new Color(0.5411765f, 0.7215686f, 0.9960784f, 1f);
    }
  }

  public static Color Mulberry
  {
    get
    {
      return new Color(0.572549f, 0.03921569f, 0.3058824f, 1f);
    }
  }

  public static Color ShockingPink
  {
    get
    {
      return new Color(0.9960784f, 0.007843138f, 0.6352941f, 1f);
    }
  }

  public static Color Auburn
  {
    get
    {
      return new Color(0.6039216f, 0.1882353f, 0.003921569f, 1f);
    }
  }

  public static Color BrightLimeGreen
  {
    get
    {
      return new Color(0.3960784f, 0.9960784f, 0.03137255f, 1f);
    }
  }

  public static Color Celadon
  {
    get
    {
      return new Color(0.7450981f, 0.9921569f, 0.7176471f, 1f);
    }
  }

  public static Color PinkishBrown
  {
    get
    {
      return new Color(0.6941177f, 0.4470588f, 0.3803922f, 1f);
    }
  }

  public static Color PooBrown
  {
    get
    {
      return new Color(0.5333334f, 0.372549f, 0.003921569f, 1f);
    }
  }

  public static Color BrightSkyBlue
  {
    get
    {
      return new Color(0.007843138f, 0.8f, 0.9960784f, 1f);
    }
  }

  public static Color Celery
  {
    get
    {
      return new Color(0.7568628f, 0.9921569f, 0.5843138f, 1f);
    }
  }

  public static Color DirtBrown
  {
    get
    {
      return new Color(0.5137255f, 0.3960784f, 0.2235294f, 1f);
    }
  }

  public static Color Strawberry
  {
    get
    {
      return new Color(0.9843137f, 0.1607843f, 0.2627451f, 1f);
    }
  }

  public static Color DarkLime
  {
    get
    {
      return new Color(0.5176471f, 0.7176471f, 0.003921569f, 1f);
    }
  }

  public static Color Copper
  {
    get
    {
      return new Color(0.7137255f, 0.3882353f, 0.145098f, 1f);
    }
  }

  public static Color MediumBrown
  {
    get
    {
      return new Color(0.4980392f, 0.3176471f, 0.07058824f, 1f);
    }
  }

  public static Color MutedGreen
  {
    get
    {
      return new Color(0.372549f, 0.627451f, 0.3215686f, 1f);
    }
  }

  public static Color RobinSEgg
  {
    get
    {
      return new Color(0.427451f, 0.9294118f, 0.9921569f, 1f);
    }
  }

  public static Color BrightAqua
  {
    get
    {
      return new Color(0.04313726f, 0.9764706f, 0.9176471f, 1f);
    }
  }

  public static Color BrightLavender
  {
    get
    {
      return new Color(0.7803922f, 0.3764706f, 1f, 1f);
    }
  }

  public static Color Ivory
  {
    get
    {
      return new Color(1f, 1f, 0.7960784f, 1f);
    }
  }

  public static Color VeryLightPurple
  {
    get
    {
      return new Color(0.9647059f, 0.8078431f, 0.9882353f, 1f);
    }
  }

  public static Color LightNavy
  {
    get
    {
      return new Color(0.08235294f, 0.3137255f, 0.5176471f, 1f);
    }
  }

  public static Color PinkRed
  {
    get
    {
      return new Color(0.9607843f, 0.01960784f, 0.3098039f, 1f);
    }
  }

  public static Color OliveBrown
  {
    get
    {
      return new Color(0.3921569f, 0.3294118f, 0.01176471f, 1f);
    }
  }

  public static Color PoopBrown
  {
    get
    {
      return new Color(0.4784314f, 0.3490196f, 0.003921569f, 1f);
    }
  }

  public static Color MustardGreen
  {
    get
    {
      return new Color(0.6588235f, 0.7098039f, 0.01568628f, 1f);
    }
  }

  public static Color OceanGreen
  {
    get
    {
      return new Color(0.2392157f, 0.6f, 0.4509804f, 1f);
    }
  }

  public static Color VeryDarkBlue
  {
    get
    {
      return new Color(0.0f, 0.003921569f, 0.2f, 1f);
    }
  }

  public static Color DustyGreen
  {
    get
    {
      return new Color(0.4627451f, 0.6627451f, 0.4509804f, 1f);
    }
  }

  public static Color LightNavyBlue
  {
    get
    {
      return new Color(0.1803922f, 0.3529412f, 0.5333334f, 1f);
    }
  }

  public static Color MintyGreen
  {
    get
    {
      return new Color(0.04313726f, 0.9686275f, 0.4901961f, 1f);
    }
  }

  public static Color Adobe
  {
    get
    {
      return new Color(0.7411765f, 0.4235294f, 0.282353f, 1f);
    }
  }

  public static Color Barney
  {
    get
    {
      return new Color(0.6745098f, 0.1137255f, 0.7215686f, 1f);
    }
  }

  public static Color JadeGreen
  {
    get
    {
      return new Color(0.1686275f, 0.6862745f, 0.4156863f, 1f);
    }
  }

  public static Color BrightLightBlue
  {
    get
    {
      return new Color(0.1490196f, 0.9686275f, 0.9921569f, 1f);
    }
  }

  public static Color LightLime
  {
    get
    {
      return new Color(0.682353f, 0.9921569f, 0.4235294f, 1f);
    }
  }

  public static Color DarkKhaki
  {
    get
    {
      return new Color(0.6078432f, 0.5607843f, 0.3333333f, 1f);
    }
  }

  public static Color OrangeYellow
  {
    get
    {
      return new Color(1f, 0.6784314f, 0.003921569f, 1f);
    }
  }

  public static Color Ocre
  {
    get
    {
      return new Color(0.7764706f, 0.6117647f, 0.01568628f, 1f);
    }
  }

  public static Color Maize
  {
    get
    {
      return new Color(0.9568627f, 0.8156863f, 0.3294118f, 1f);
    }
  }

  public static Color FadedPink
  {
    get
    {
      return new Color(0.8705882f, 0.6156863f, 0.6745098f, 1f);
    }
  }

  public static Color BritishRacingGreen
  {
    get
    {
      return new Color(0.01960784f, 0.282353f, 0.05098039f, 1f);
    }
  }

  public static Color Sandstone
  {
    get
    {
      return new Color(0.7882353f, 0.682353f, 0.454902f, 1f);
    }
  }

  public static Color MudBrown
  {
    get
    {
      return new Color(0.3764706f, 0.2745098f, 0.05882353f, 1f);
    }
  }

  public static Color LightSeaGreen
  {
    get
    {
      return new Color(0.5960785f, 0.9647059f, 0.6901961f, 1f);
    }
  }

  public static Color RobinEggBlue
  {
    get
    {
      return new Color(0.5411765f, 0.945098f, 0.9960784f, 1f);
    }
  }

  public static Color AquaMarine
  {
    get
    {
      return new Color(0.1803922f, 0.9098039f, 0.7333333f, 1f);
    }
  }

  public static Color DarkSeaGreen
  {
    get
    {
      return new Color(0.06666667f, 0.5294118f, 0.3647059f, 1f);
    }
  }

  public static Color SoftPink
  {
    get
    {
      return new Color(0.9921569f, 0.6901961f, 0.7529412f, 1f);
    }
  }

  public static Color OrangeyBrown
  {
    get
    {
      return new Color(0.6941177f, 0.3764706f, 0.007843138f, 1f);
    }
  }

  public static Color CherryRed
  {
    get
    {
      return new Color(0.9686275f, 0.007843138f, 0.1647059f, 1f);
    }
  }

  public static Color BurntYellow
  {
    get
    {
      return new Color(0.8352941f, 0.6705883f, 0.03529412f, 1f);
    }
  }

  public static Color BrownishGrey
  {
    get
    {
      return new Color(0.5254902f, 0.4666667f, 0.372549f, 1f);
    }
  }

  public static Color Camel
  {
    get
    {
      return new Color(0.7764706f, 0.6235294f, 0.3490196f, 1f);
    }
  }

  public static Color PurplishGrey
  {
    get
    {
      return new Color(0.4784314f, 0.4078431f, 0.4980392f, 1f);
    }
  }

  public static Color Marine
  {
    get
    {
      return new Color(0.01568628f, 0.1803922f, 0.3764706f, 1f);
    }
  }

  public static Color GreyishPink
  {
    get
    {
      return new Color(0.7843137f, 0.5529412f, 0.5803922f, 1f);
    }
  }

  public static Color PaleTurquoise
  {
    get
    {
      return new Color(0.6470588f, 0.9843137f, 0.8352941f, 1f);
    }
  }

  public static Color PastelYellow
  {
    get
    {
      return new Color(1f, 0.9960784f, 0.4431373f, 1f);
    }
  }

  public static Color BlueyPurple
  {
    get
    {
      return new Color(0.3843137f, 0.254902f, 0.7803922f, 1f);
    }
  }

  public static Color CanaryYellow
  {
    get
    {
      return new Color(1f, 0.9960784f, 0.2509804f, 1f);
    }
  }

  public static Color FadedRed
  {
    get
    {
      return new Color(0.827451f, 0.2862745f, 0.3058824f, 1f);
    }
  }

  public static Color Sepia
  {
    get
    {
      return new Color(0.5960785f, 0.3686275f, 0.1686275f, 1f);
    }
  }

  public static Color Coffee
  {
    get
    {
      return new Color(0.6509804f, 0.5058824f, 0.2980392f, 1f);
    }
  }

  public static Color BrightMagenta
  {
    get
    {
      return new Color(1f, 0.03137255f, 0.9098039f, 1f);
    }
  }

  public static Color Mocha
  {
    get
    {
      return new Color(0.6156863f, 0.4627451f, 0.3176471f, 1f);
    }
  }

  public static Color Ecru
  {
    get
    {
      return new Color(0.9960784f, 1f, 0.7921569f, 1f);
    }
  }

  public static Color Purpleish
  {
    get
    {
      return new Color(0.5960785f, 0.3372549f, 0.5529412f, 1f);
    }
  }

  public static Color Cranberry
  {
    get
    {
      return new Color(0.6196079f, 0.0f, 0.227451f, 1f);
    }
  }

  public static Color DarkishGreen
  {
    get
    {
      return new Color(0.1568628f, 0.4862745f, 68.0f * (float)Math.E / 857.0f, 1f);
    }
  }

  public static Color BrownOrange
  {
    get
    {
      return new Color(0.7254902f, 0.4117647f, 0.007843138f, 1f);
    }
  }

  public static Color DuskyRose
  {
    get
    {
      return new Color(0.7294118f, 0.4078431f, 0.4509804f, 1f);
    }
  }

  public static Color Melon
  {
    get
    {
      return new Color(1f, 0.4705882f, 0.3333333f, 1f);
    }
  }

  public static Color SicklyGreen
  {
    get
    {
      return new Color(0.5803922f, 0.6980392f, 0.1098039f, 1f);
    }
  }

  public static Color Silver
  {
    get
    {
      return new Color(0.772549f, 0.7882353f, 0.7803922f, 1f);
    }
  }

  public static Color PurplyBlue
  {
    get
    {
      return new Color(0.4f, 0.1019608f, 0.9333333f, 1f);
    }
  }

  public static Color PurpleishBlue
  {
    get
    {
      return new Color(0.3803922f, 0.2509804f, 0.9372549f, 1f);
    }
  }

  public static Color HospitalGreen
  {
    get
    {
      return new Color(0.6078432f, 0.8980392f, 0.6666667f, 1f);
    }
  }

  public static Color ShitBrown
  {
    get
    {
      return new Color(0.4823529f, 0.345098f, 0.01568628f, 1f);
    }
  }

  public static Color MidBlue
  {
    get
    {
      return new Color(0.1529412f, 0.4156863f, 0.7019608f, 1f);
    }
  }

  public static Color Amber
  {
    get
    {
      return new Color(0.9960784f, 0.7019608f, 0.03137255f, 1f);
    }
  }

  public static Color EasterGreen
  {
    get
    {
      return new Color(0.5490196f, 0.9921569f, 0.4941176f, 1f);
    }
  }

  public static Color SoftBlue
  {
    get
    {
      return new Color(0.3921569f, 0.5333334f, 0.9176471f, 1f);
    }
  }

  public static Color CeruleanBlue
  {
    get
    {
      return new Color(0.01960784f, 0.4313726f, 0.9333333f, 1f);
    }
  }

  public static Color GoldenBrown
  {
    get
    {
      return new Color(0.6980392f, 0.4784314f, 0.003921569f, 1f);
    }
  }

  public static Color BrightTurquoise
  {
    get
    {
      return new Color(0.05882353f, 0.9960784f, 0.9764706f, 1f);
    }
  }

  public static Color RedPink
  {
    get
    {
      return new Color(0.9803922f, 0.1647059f, 0.3333333f, 1f);
    }
  }

  public static Color RedPurple
  {
    get
    {
      return new Color(0.509804f, 0.02745098f, 0.2784314f, 1f);
    }
  }

  public static Color GreyishBrown
  {
    get
    {
      return new Color(0.4784314f, 0.4156863f, 0.3098039f, 1f);
    }
  }

  public static Color Vermillion
  {
    get
    {
      return new Color(0.9568627f, 0.1960784f, 0.04705882f, 1f);
    }
  }

  public static Color Russet
  {
    get
    {
      return new Color(0.6313726f, 0.2235294f, 0.01960784f, 1f);
    }
  }

  public static Color SteelGrey
  {
    get
    {
      return new Color(0.4352941f, 0.509804f, 0.5411765f, 1f);
    }
  }

  public static Color LighterPurple
  {
    get
    {
      return new Color(0.6470588f, 0.3529412f, 0.9568627f, 1f);
    }
  }

  public static Color BrightViolet
  {
    get
    {
      return new Color(0.6784314f, 0.03921569f, 0.9921569f, 1f);
    }
  }

  public static Color PrussianBlue
  {
    get
    {
      return new Color(0.0f, 0.2705882f, 0.4666667f, 1f);
    }
  }

  public static Color SlateGreen
  {
    get
    {
      return new Color(0.3960784f, 0.5529412f, 0.427451f, 1f);
    }
  }

  public static Color DirtyPink
  {
    get
    {
      return new Color(0.7921569f, 0.4823529f, 0.5019608f, 1f);
    }
  }

  public static Color DarkBlueGreen
  {
    get
    {
      return new Color(0.0f, 0.3215686f, 0.2862745f, 1f);
    }
  }

  public static Color Pine
  {
    get
    {
      return new Color(0.1686275f, 0.3647059f, 0.2039216f, 1f);
    }
  }

  public static Color YellowyGreen
  {
    get
    {
      return new Color(0.7490196f, 0.945098f, 0.1568628f, 1f);
    }
  }

  public static Color DarkGold
  {
    get
    {
      return new Color(0.7098039f, 0.5803922f, 0.0627451f, 1f);
    }
  }

  public static Color Bluish
  {
    get
    {
      return new Color(0.1607843f, 0.4627451f, 0.7333333f, 1f);
    }
  }

  public static Color DarkishBlue
  {
    get
    {
      return new Color(0.003921569f, 0.254902f, 0.509804f, 1f);
    }
  }

  public static Color DullRed
  {
    get
    {
      return new Color(0.7333333f, 0.2470588f, 0.2470588f, 1f);
    }
  }

  public static Color PinkyRed
  {
    get
    {
      return new Color(0.9882353f, 0.1490196f, 0.2784314f, 1f);
    }
  }

  public static Color Bronze
  {
    get
    {
      return new Color(0.6588235f, 0.4745098f, 0.0f, 1f);
    }
  }

  public static Color PaleTeal
  {
    get
    {
      return new Color(0.509804f, 0.7960784f, 0.6980392f, 1f);
    }
  }

  public static Color MilitaryGreen
  {
    get
    {
      return new Color(0.4f, 0.4862745f, 0.2431373f, 1f);
    }
  }

  public static Color BarbiePink
  {
    get
    {
      return new Color(0.9960784f, 0.2745098f, 0.6470588f, 1f);
    }
  }

  public static Color BubblegumPink
  {
    get
    {
      return new Color(0.9960784f, 0.5137255f, 0.8f, 1f);
    }
  }

  public static Color PeaSoupGreen
  {
    get
    {
      return new Color(0.5803922f, 0.6509804f, 0.09019608f, 1f);
    }
  }

  public static Color DarkMustard
  {
    get
    {
      return new Color(0.6588235f, 0.5372549f, 0.01960784f, 1f);
    }
  }

  public static Color Shit
  {
    get
    {
      return new Color(0.4980392f, 0.372549f, 0.0f, 1f);
    }
  }

  public static Color MediumPurple
  {
    get
    {
      return new Color(0.6196079f, 0.2627451f, 0.6352941f, 1f);
    }
  }

  public static Color VeryDarkGreen
  {
    get
    {
      return new Color(0.02352941f, 0.1803922f, 0.01176471f, 1f);
    }
  }

  public static Color Dirt
  {
    get
    {
      return new Color(0.5411765f, 0.4313726f, 0.2705882f, 1f);
    }
  }

  public static Color DuskyPink
  {
    get
    {
      return new Color(0.8f, 0.4784314f, 0.5450981f, 1f);
    }
  }

  public static Color RedViolet
  {
    get
    {
      return new Color(0.6196079f, 0.003921569f, 0.4078431f, 1f);
    }
  }

  public static Color LemonYellow
  {
    get
    {
      return new Color(0.9921569f, 1f, 0.2196078f, 1f);
    }
  }

  public static Color Pistachio
  {
    get
    {
      return new Color(0.7529412f, 0.9803922f, 0.5450981f, 1f);
    }
  }

  public static Color DullYellow
  {
    get
    {
      return new Color(0.9333333f, 0.8627451f, 0.3568628f, 1f);
    }
  }

  public static Color DarkLimeGreen
  {
    get
    {
      return new Color(0.4941176f, 0.7411765f, 0.003921569f, 1f);
    }
  }

  public static Color DenimBlue
  {
    get
    {
      return new Color(0.2313726f, 0.3568628f, 0.572549f, 1f);
    }
  }

  public static Color TealBlue
  {
    get
    {
      return new Color(0.003921569f, 0.5333334f, 0.6235294f, 1f);
    }
  }

  public static Color LightishBlue
  {
    get
    {
      return new Color(0.2392157f, 0.4784314f, 0.9921569f, 1f);
    }
  }

  public static Color PurpleyBlue
  {
    get
    {
      return new Color(0.372549f, 0.2039216f, 0.9058824f, 1f);
    }
  }

  public static Color LightIndigo
  {
    get
    {
      return new Color(0.427451f, 0.3529412f, 0.8117647f, 1f);
    }
  }

  public static Color SwampGreen
  {
    get
    {
      return new Color(0.454902f, 0.5215687f, 0.0f, 1f);
    }
  }

  public static Color BrownGreen
  {
    get
    {
      return new Color(0.4392157f, 0.4235294f, 0.06666667f, 1f);
    }
  }

  public static Color DarkMaroon
  {
    get
    {
      return new Color(0.2352941f, 0.0f, 0.03137255f, 1f);
    }
  }

  public static Color HotPurple
  {
    get
    {
      return new Color(0.7960784f, 0.0f, 0.9607843f, 1f);
    }
  }

  public static Color DarkForestGreen
  {
    get
    {
      return new Color(0.0f, 0.1764706f, 0.01568628f, 1f);
    }
  }

  public static Color FadedBlue
  {
    get
    {
      return new Color(0.3960784f, 0.5490196f, 0.7333333f, 1f);
    }
  }

  public static Color DrabGreen
  {
    get
    {
      return new Color(0.454902f, 0.5843138f, 0.3176471f, 1f);
    }
  }

  public static Color LightLimeGreen
  {
    get
    {
      return new Color(0.7254902f, 1f, 0.4f, 1f);
    }
  }

  public static Color SnotGreen
  {
    get
    {
      return new Color(0.6156863f, 0.7568628f, 0.0f, 1f);
    }
  }

  public static Color Yellowish
  {
    get
    {
      return new Color(0.9803922f, 0.9333333f, 0.4f, 1f);
    }
  }

  public static Color LightBlueGreen
  {
    get
    {
      return new Color(0.4941176f, 0.9843137f, 0.7019608f, 1f);
    }
  }

  public static Color Bordeaux
  {
    get
    {
      return new Color(0.4823529f, 0.0f, 0.172549f, 1f);
    }
  }

  public static Color LightMauve
  {
    get
    {
      return new Color(0.7607843f, 0.572549f, 0.6313726f, 1f);
    }
  }

  public static Color Ocean
  {
    get
    {
      return new Color(0.003921569f, 0.4823529f, 0.572549f, 1f);
    }
  }

  public static Color Marigold
  {
    get
    {
      return new Color(0.9882353f, 0.7529412f, 0.02352941f, 1f);
    }
  }

  public static Color MuddyGreen
  {
    get
    {
      return new Color(0.3960784f, 0.454902f, 0.1960784f, 1f);
    }
  }

  public static Color DullOrange
  {
    get
    {
      return new Color(0.8470588f, 0.5254902f, 0.2313726f, 1f);
    }
  }

  public static Color Steel
  {
    get
    {
      return new Color(0.4509804f, 0.5215687f, 0.5843138f, 1f);
    }
  }

  public static Color ElectricPurple
  {
    get
    {
      return new Color(0.6666667f, 0.1372549f, 1f, 1f);
    }
  }

  public static Color FluorescentGreen
  {
    get
    {
      return new Color(0.03137255f, 1f, 0.03137255f, 1f);
    }
  }

  public static Color YellowishBrown
  {
    get
    {
      return new Color(0.6078432f, 0.4784314f, 0.003921569f, 1f);
    }
  }

  public static Color Blush
  {
    get
    {
      return new Color(0.9490196f, 0.6196079f, 0.5568628f, 1f);
    }
  }

  public static Color SoftGreen
  {
    get
    {
      return new Color(0.4352941f, 0.7607843f, 0.4627451f, 1f);
    }
  }

  public static Color BrightOrange
  {
    get
    {
      return new Color(1f, 0.3568628f, 0.0f, 1f);
    }
  }

  public static Color Lemon
  {
    get
    {
      return new Color(0.9921569f, 1f, 0.3215686f, 1f);
    }
  }

  public static Color PurpleGrey
  {
    get
    {
      return new Color(0.5254902f, 0.4352941f, 0.5215687f, 1f);
    }
  }

  public static Color AcidGreen
  {
    get
    {
      return new Color(0.5607843f, 0.9960784f, 0.03529412f, 1f);
    }
  }

  public static Color PaleLavender
  {
    get
    {
      return new Color(0.9333333f, 0.8117647f, 0.9960784f, 1f);
    }
  }

  public static Color VioletBlue
  {
    get
    {
      return new Color(0.3176471f, 0.03921569f, 0.7882353f, 1f);
    }
  }

  public static Color LightForestGreen
  {
    get
    {
      return new Color(0.3098039f, 0.5686275f, 0.3254902f, 1f);
    }
  }

  public static Color BurntRed
  {
    get
    {
      return new Color(0.6235294f, 0.1372549f, 0.01960784f, 1f);
    }
  }

  public static Color KhakiGreen
  {
    get
    {
      return new Color(0.4470588f, 0.5254902f, 0.2235294f, 1f);
    }
  }

  public static Color Cerise
  {
    get
    {
      return new Color(0.8705882f, 0.04705882f, 0.3843137f, 1f);
    }
  }

  public static Color FadedPurple
  {
    get
    {
      return new Color(0.5686275f, 0.4313726f, 0.6f, 1f);
    }
  }

  public static Color Apricot
  {
    get
    {
      return new Color(1f, 0.6941177f, 0.427451f, 1f);
    }
  }

  public static Color DarkOliveGreen
  {
    get
    {
      return new Color(0.2352941f, 0.3019608f, 0.01176471f, 1f);
    }
  }

  public static Color GreyBrown
  {
    get
    {
      return new Color(0.4980392f, 0.4392157f, 0.3254902f, 1f);
    }
  }

  public static Color GreenGrey
  {
    get
    {
      return new Color(0.4666667f, 0.572549f, 0.4352941f, 1f);
    }
  }

  public static Color TrueBlue
  {
    get
    {
      return new Color(0.003921569f, 0.05882353f, 0.8f, 1f);
    }
  }

  public static Color PaleViolet
  {
    get
    {
      return new Color(0.8078431f, 0.682353f, 0.9803922f, 1f);
    }
  }

  public static Color PeriwinkleBlue
  {
    get
    {
      return new Color(0.5607843f, 0.6f, 0.9843137f, 1f);
    }
  }

  public static Color LightSkyBlue
  {
    get
    {
      return new Color(0.7764706f, 0.9882353f, 1f, 1f);
    }
  }

  public static Color Blurple
  {
    get
    {
      return new Color(0.3333333f, 0.2235294f, 0.8f, 1f);
    }
  }

  public static Color GreenBrown
  {
    get
    {
      return new Color(0.3294118f, 0.3058824f, 0.01176471f, 1f);
    }
  }

  public static Color Bluegreen
  {
    get
    {
      return new Color(0.003921569f, 0.4784314f, 0.4745098f, 1f);
    }
  }

  public static Color BrightTeal
  {
    get
    {
      return new Color(0.003921569f, 0.9764706f, 0.7764706f, 1f);
    }
  }

  public static Color BrownishYellow
  {
    get
    {
      return new Color(0.7882353f, 0.6901961f, 0.01176471f, 1f);
    }
  }

  public static Color PeaSoup
  {
    get
    {
      return new Color(0.572549f, 0.6f, 0.003921569f, 1f);
    }
  }

  public static Color Forest
  {
    get
    {
      return new Color(0.04313726f, 0.3333333f, 0.03529412f, 1f);
    }
  }

  public static Color BarneyPurple
  {
    get
    {
      return new Color(0.627451f, 0.01568628f, 0.5960785f, 1f);
    }
  }

  public static Color Ultramarine
  {
    get
    {
      return new Color(0.1254902f, 0.0f, 0.6941177f, 1f);
    }
  }

  public static Color Purplish
  {
    get
    {
      return new Color(0.5803922f, 0.3372549f, 0.5490196f, 1f);
    }
  }

  public static Color PukeYellow
  {
    get
    {
      return new Color(0.7607843f, 0.7450981f, 0.05490196f, 1f);
    }
  }

  public static Color BluishGrey
  {
    get
    {
      return new Color(0.454902f, 0.5450981f, 0.5921569f, 1f);
    }
  }

  public static Color DarkPeriwinkle
  {
    get
    {
      return new Color(0.4f, 0.372549f, 0.8196079f, 1f);
    }
  }

  public static Color DarkLilac
  {
    get
    {
      return new Color(0.6117647f, 0.427451f, 0.6470588f, 1f);
    }
  }

  public static Color Reddish
  {
    get
    {
      return new Color(0.7686275f, 0.2588235f, 0.2509804f, 1f);
    }
  }

  public static Color LightMaroon
  {
    get
    {
      return new Color(0.6352941f, 0.282353f, 0.3411765f, 1f);
    }
  }

  public static Color DustyPurple
  {
    get
    {
      return new Color(0.509804f, 0.372549f, 0.5294118f, 1f);
    }
  }

  public static Color TerraCotta
  {
    get
    {
      return new Color(0.7882353f, 0.3921569f, 0.2313726f, 1f);
    }
  }

  public static Color Avocado
  {
    get
    {
      return new Color(0.5647059f, 0.6941177f, 0.2039216f, 1f);
    }
  }

  public static Color MarineBlue
  {
    get
    {
      return new Color(0.003921569f, 0.2196078f, 0.4156863f, 1f);
    }
  }

  public static Color TealGreen
  {
    get
    {
      return new Color(0.145098f, 0.6392157f, 0.4352941f, 1f);
    }
  }

  public static Color SlateGrey
  {
    get
    {
      return new Color(0.3490196f, 0.3960784f, 0.427451f, 1f);
    }
  }

  public static Color LighterGreen
  {
    get
    {
      return new Color(0.4588235f, 0.9921569f, 0.3882353f, 1f);
    }
  }

  public static Color ElectricGreen
  {
    get
    {
      return new Color(0.1294118f, 0.9882353f, 0.05098039f, 1f);
    }
  }

  public static Color DustyBlue
  {
    get
    {
      return new Color(0.3529412f, 0.5254902f, 0.6784314f, 1f);
    }
  }

  public static Color GoldenYellow
  {
    get
    {
      return new Color(0.9960784f, 0.7764706f, 0.08235294f, 1f);
    }
  }

  public static Color BrightYellow
  {
    get
    {
      return new Color(1f, 0.9921569f, 0.003921569f, 1f);
    }
  }

  public static Color LightLavender
  {
    get
    {
      return new Color(0.8745098f, 0.772549f, 0.9960784f, 1f);
    }
  }

  public static Color Umber
  {
    get
    {
      return new Color(0.6980392f, 0.3921569f, 0.0f, 1f);
    }
  }

  public static Color Poop
  {
    get
    {
      return new Color(0.4980392f, 0.3686275f, 0.0f, 1f);
    }
  }

  public static Color DarkPeach
  {
    get
    {
      return new Color(0.8705882f, 0.4941176f, 0.3647059f, 1f);
    }
  }

  public static Color JungleGreen
  {
    get
    {
      return new Color(0.01568628f, 0.509804f, 0.2627451f, 1f);
    }
  }

  public static Color Eggshell
  {
    get
    {
      return new Color(1f, 1f, 0.8313726f, 1f);
    }
  }

  public static Color Denim
  {
    get
    {
      return new Color(0.2313726f, 0.3882353f, 0.5490196f, 1f);
    }
  }

  public static Color YellowBrown
  {
    get
    {
      return new Color(0.7176471f, 0.5803922f, 0.0f, 1f);
    }
  }

  public static Color DullPurple
  {
    get
    {
      return new Color(0.5176471f, 0.3490196f, 0.4941176f, 1f);
    }
  }

  public static Color ChocolateBrown
  {
    get
    {
      return new Color(0.254902f, 0.09803922f, 0.0f, 1f);
    }
  }

  public static Color WineRed
  {
    get
    {
      return new Color(0.4823529f, 0.01176471f, 0.1372549f, 1f);
    }
  }

  public static Color NeonBlue
  {
    get
    {
      return new Color(0.01568628f, 0.8509804f, 1f, 1f);
    }
  }

  public static Color DirtyGreen
  {
    get
    {
      return new Color(0.4f, 0.4941176f, 0.172549f, 1f);
    }
  }

  public static Color LightTan
  {
    get
    {
      return new Color(0.9843137f, 0.9333333f, 0.6745098f, 1f);
    }
  }

  public static Color IceBlue
  {
    get
    {
      return new Color(0.8431373f, 1f, 0.9960784f, 1f);
    }
  }

  public static Color CadetBlue
  {
    get
    {
      return new Color(0.3058824f, 0.454902f, 0.5882353f, 1f);
    }
  }

  public static Color DarkMauve
  {
    get
    {
      return new Color(0.5294118f, 0.2980392f, 0.3843137f, 1f);
    }
  }

  public static Color VeryLightBlue
  {
    get
    {
      return new Color(0.8352941f, 1f, 1f, 1f);
    }
  }

  public static Color GreyPurple
  {
    get
    {
      return new Color(0.509804f, 0.427451f, 0.5490196f, 1f);
    }
  }

  public static Color PastelPink
  {
    get
    {
      return new Color(1f, 0.7294118f, 0.8039216f, 1f);
    }
  }

  public static Color VeryLightGreen
  {
    get
    {
      return new Color(0.8196079f, 1f, 0.7411765f, 1f);
    }
  }

  public static Color DarkSkyBlue
  {
    get
    {
      return new Color(0.2666667f, 0.5568628f, 0.8941177f, 1f);
    }
  }

  public static Color Evergreen
  {
    get
    {
      return new Color(0.01960784f, 0.2784314f, 0.1647059f, 1f);
    }
  }

  public static Color DullPink
  {
    get
    {
      return new Color(0.8352941f, 0.5254902f, 0.6156863f, 1f);
    }
  }

  public static Color Aubergine
  {
    get
    {
      return new Color(0.2392157f, 0.02745098f, 0.2039216f, 1f);
    }
  }

  public static Color Mahogany
  {
    get
    {
      return new Color(0.2901961f, 0.003921569f, 0.0f, 1f);
    }
  }

  public static Color ReddishOrange
  {
    get
    {
      return new Color(0.972549f, 0.282353f, 0.1098039f, 1f);
    }
  }

  public static Color DeepGreen
  {
    get
    {
      return new Color(0.007843138f, 0.3490196f, 0.05882353f, 1f);
    }
  }

  public static Color VomitGreen
  {
    get
    {
      return new Color(0.5372549f, 0.6352941f, 0.01176471f, 1f);
    }
  }

  public static Color PurplePink
  {
    get
    {
      return new Color(0.8784314f, 0.2470588f, 0.8470588f, 1f);
    }
  }

  public static Color DustyPink
  {
    get
    {
      return new Color(0.8352941f, 0.5411765f, 0.5803922f, 1f);
    }
  }

  public static Color FadedGreen
  {
    get
    {
      return new Color(0.4823529f, 0.6980392f, 0.454902f, 1f);
    }
  }

  public static Color CamoGreen
  {
    get
    {
      return new Color(0.3215686f, 0.3960784f, 0.145098f, 1f);
    }
  }

  public static Color PinkyPurple
  {
    get
    {
      return new Color(0.7882353f, 0.2980392f, 0.7450981f, 1f);
    }
  }

  public static Color PinkPurple
  {
    get
    {
      return new Color(0.8588235f, 0.2941177f, 0.854902f, 1f);
    }
  }

  public static Color BrownishRed
  {
    get
    {
      return new Color(0.6196079f, 0.2117647f, 0.1372549f, 1f);
    }
  }

  public static Color DarkRose
  {
    get
    {
      return new Color(0.7098039f, 0.282353f, 0.3647059f, 1f);
    }
  }

  public static Color Mud
  {
    get
    {
      return new Color(0.4509804f, 0.3607843f, 0.07058824f, 1f);
    }
  }

  public static Color Brownish
  {
    get
    {
      return new Color(0.6117647f, 0.427451f, 0.3411765f, 1f);
    }
  }

  public static Color EmeraldGreen
  {
    get
    {
      return new Color(0.007843138f, 0.5607843f, 0.1176471f, 1f);
    }
  }

  public static Color PaleBrown
  {
    get
    {
      return new Color(0.6941177f, 0.5686275f, 0.4313726f, 1f);
    }
  }

  public static Color DullBlue
  {
    get
    {
      return new Color(0.2862745f, 0.4588235f, 0.6117647f, 1f);
    }
  }

  public static Color BurntUmber
  {
    get
    {
      return new Color(0.627451f, 0.2705882f, 0.05490196f, 1f);
    }
  }

  public static Color MediumGreen
  {
    get
    {
      return new Color(0.2235294f, 0.6784314f, 0.282353f, 1f);
    }
  }

  public static Color Clay
  {
    get
    {
      return new Color(0.7137255f, 0.4156863f, 0.3137255f, 1f);
    }
  }

  public static Color LightAqua
  {
    get
    {
      return new Color(0.5490196f, 1f, 0.8588235f, 1f);
    }
  }

  public static Color LightOliveGreen
  {
    get
    {
      return new Color(0.6431373f, 0.7450981f, 0.3607843f, 1f);
    }
  }

  public static Color BrownishOrange
  {
    get
    {
      return new Color(0.7960784f, 0.4666667f, 0.1372549f, 1f);
    }
  }

  public static Color DarkAqua
  {
    get
    {
      return new Color(0.01960784f, 0.4117647f, 0.4196078f, 1f);
    }
  }

  public static Color PurplishPink
  {
    get
    {
      return new Color(0.8078431f, 0.3647059f, 0.682353f, 1f);
    }
  }

  public static Color DarkSalmon
  {
    get
    {
      return new Color(0.7843137f, 0.3529412f, 0.3254902f, 1f);
    }
  }

  public static Color GreenishGrey
  {
    get
    {
      return new Color(0.5882353f, 0.682353f, 0.5529412f, 1f);
    }
  }

  public static Color Jade
  {
    get
    {
      return new Color(0.1215686f, 0.654902f, 0.454902f, 1f);
    }
  }

  public static Color UglyGreen
  {
    get
    {
      return new Color(0.4784314f, 0.5921569f, 0.01176471f, 1f);
    }
  }

  public static Color DarkBeige
  {
    get
    {
      return new Color(0.6745098f, 0.5764706f, 0.3843137f, 1f);
    }
  }

  public static Color Emerald
  {
    get
    {
      return new Color(0.003921569f, 0.627451f, 0.2862745f, 1f);
    }
  }

  public static Color PaleRed
  {
    get
    {
      return new Color(0.8509804f, 0.3294118f, 0.3019608f, 1f);
    }
  }

  public static Color LightMagenta
  {
    get
    {
      return new Color(0.9803922f, 0.372549f, 0.9686275f, 1f);
    }
  }

  public static Color Sky
  {
    get
    {
      return new Color(0.509804f, 0.7921569f, 0.9882353f, 1f);
    }
  }

  public static Color LightCyan
  {
    get
    {
      return new Color(0.6745098f, 1f, 0.9882353f, 1f);
    }
  }

  public static Color YellowOrange
  {
    get
    {
      return new Color(0.9882353f, 0.6901961f, 0.003921569f, 1f);
    }
  }

  public static Color ReddishPurple
  {
    get
    {
      return new Color(0.5686275f, 0.03529412f, 0.3176471f, 1f);
    }
  }

  public static Color ReddishPink
  {
    get
    {
      return new Color(0.9960784f, 0.172549f, 0.3294118f, 1f);
    }
  }

  public static Color Orchid
  {
    get
    {
      return new Color(0.7843137f, 0.4588235f, 0.7686275f, 1f);
    }
  }

  public static Color DirtyYellow
  {
    get
    {
      return new Color(0.8039216f, 0.772549f, 0.03921569f, 1f);
    }
  }

  public static Color OrangeRed
  {
    get
    {
      return new Color(0.9921569f, 0.254902f, 0.1176471f, 1f);
    }
  }

  public static Color DeepRed
  {
    get
    {
      return new Color(0.6039216f, 0.007843138f, 0.0f, 1f);
    }
  }

  public static Color OrangeBrown
  {
    get
    {
      return new Color(0.7450981f, 0.3921569f, 0.0f, 1f);
    }
  }

  public static Color CobaltBlue
  {
    get
    {
      return new Color(0.01176471f, 0.03921569f, 0.654902f, 1f);
    }
  }

  public static Color NeonPink
  {
    get
    {
      return new Color(0.9960784f, 0.003921569f, 0.6039216f, 1f);
    }
  }

  public static Color RosePink
  {
    get
    {
      return new Color(0.9686275f, 0.5294118f, 0.6039216f, 1f);
    }
  }

  public static Color GreyishPurple
  {
    get
    {
      return new Color(0.5333334f, 0.4431373f, 0.5686275f, 1f);
    }
  }

  public static Color Raspberry
  {
    get
    {
      return new Color(0.6901961f, 0.003921569f, 0.2862745f, 1f);
    }
  }

  public static Color AquaGreen
  {
    get
    {
      return new Color(0.07058824f, 0.8823529f, 0.5764706f, 1f);
    }
  }

  public static Color SalmonPink
  {
    get
    {
      return new Color(0.9960784f, 0.4823529f, 0.4862745f, 1f);
    }
  }

  public static Color Tangerine
  {
    get
    {
      return new Color(1f, 0.5803922f, 0.03137255f, 1f);
    }
  }

  public static Color BrownishGreen
  {
    get
    {
      return new Color(0.4156863f, 0.4313726f, 0.03529412f, 1f);
    }
  }

  public static Color RedBrown
  {
    get
    {
      return new Color(0.5450981f, 0.1803922f, 0.08627451f, 1f);
    }
  }

  public static Color GreenishBrown
  {
    get
    {
      return new Color(0.4117647f, 0.3803922f, 0.07058824f, 1f);
    }
  }

  public static Color Pumpkin
  {
    get
    {
      return new Color(0.8823529f, 0.4666667f, 0.003921569f, 1f);
    }
  }

  public static Color PineGreen
  {
    get
    {
      return new Color(0.03921569f, 0.282353f, 0.1176471f, 1f);
    }
  }

  public static Color Charcoal
  {
    get
    {
      return new Color(0.2039216f, 0.2196078f, 68.0f * (float)Math.E / 857.0f, 1f);
    }
  }

  public static Color BabyPink
  {
    get
    {
      return new Color(1f, 0.7176471f, 0.8078431f, 1f);
    }
  }

  public static Color Cornflower
  {
    get
    {
      return new Color(0.4156863f, 0.4745098f, 0.9686275f, 1f);
    }
  }

  public static Color BlueViolet
  {
    get
    {
      return new Color(0.3647059f, 0.02352941f, 0.9137255f, 1f);
    }
  }

  public static Color Chocolate
  {
    get
    {
      return new Color(0.2392157f, 0.1098039f, 0.007843138f, 1f);
    }
  }

  public static Color GreyishGreen
  {
    get
    {
      return new Color(0.509804f, 0.6509804f, 0.4901961f, 1f);
    }
  }

  public static Color Scarlet
  {
    get
    {
      return new Color(0.7450981f, 0.003921569f, 0.09803922f, 1f);
    }
  }

  public static Color GreenYellow
  {
    get
    {
      return new Color(0.7882353f, 1f, 0.1529412f, 1f);
    }
  }

  public static Color DarkOlive
  {
    get
    {
      return new Color(68.0f * (float)Math.E / 857.0f, 0.2431373f, 0.007843138f, 1f);
    }
  }

  public static Color Sienna
  {
    get
    {
      return new Color(0.6627451f, 0.3372549f, 0.1176471f, 1f);
    }
  }

  public static Color PastelPurple
  {
    get
    {
      return new Color(0.7921569f, 0.627451f, 1f, 1f);
    }
  }

  public static Color Terracotta
  {
    get
    {
      return new Color(0.7921569f, 0.4f, 0.254902f, 1f);
    }
  }

  public static Color AquaBlue
  {
    get
    {
      return new Color(0.007843138f, 0.8470588f, 0.9137255f, 1f);
    }
  }

  public static Color SageGreen
  {
    get
    {
      return new Color(0.5333334f, 0.7019608f, 0.4705882f, 1f);
    }
  }

  public static Color BloodRed
  {
    get
    {
      return new Color(0.5960785f, 0.0f, 0.007843138f, 1f);
    }
  }

  public static Color DeepPink
  {
    get
    {
      return new Color(0.7960784f, 0.003921569f, 0.3843137f, 1f);
    }
  }

  public static Color Grass
  {
    get
    {
      return new Color(0.3607843f, 0.6745098f, 0.1764706f, 1f);
    }
  }

  public static Color Moss
  {
    get
    {
      return new Color(0.4627451f, 0.6f, 0.345098f, 1f);
    }
  }

  public static Color PastelBlue
  {
    get
    {
      return new Color(0.6352941f, 0.7490196f, 0.9960784f, 1f);
    }
  }

  public static Color BluishGreen
  {
    get
    {
      return new Color(0.0627451f, 0.6509804f, 0.454902f, 1f);
    }
  }

  public static Color GreenBlue
  {
    get
    {
      return new Color(0.02352941f, 0.7058824f, 0.5450981f, 1f);
    }
  }

  public static Color DarkTan
  {
    get
    {
      return new Color(0.6862745f, 0.5333334f, 0.2901961f, 1f);
    }
  }

  public static Color GreenishBlue
  {
    get
    {
      return new Color(0.04313726f, 0.5450981f, 0.5294118f, 1f);
    }
  }

  public static Color PaleOrange
  {
    get
    {
      return new Color(1f, 0.654902f, 0.3372549f, 1f);
    }
  }

  public static Color Vomit
  {
    get
    {
      return new Color(0.6352941f, 0.6431373f, 0.08235294f, 1f);
    }
  }

  public static Color ForrestGreen
  {
    get
    {
      return new Color(0.08235294f, 0.2666667f, 0.02352941f, 1f);
    }
  }

  public static Color DarkLavender
  {
    get
    {
      return new Color(0.5215687f, 0.4039216f, 0.5960785f, 1f);
    }
  }

  public static Color DarkViolet
  {
    get
    {
      return new Color(0.2039216f, 0.003921569f, 0.2470588f, 1f);
    }
  }

  public static Color PurpleBlue
  {
    get
    {
      return new Color(0.3882353f, 0.1764706f, 0.9137255f, 1f);
    }
  }

  public static Color DarkCyan
  {
    get
    {
      return new Color(0.03921569f, 0.5333334f, 0.5411765f, 1f);
    }
  }

  public static Color OliveDrab
  {
    get
    {
      return new Color(0.4352941f, 0.4627451f, 0.1960784f, 1f);
    }
  }

  public static Color Pinkish
  {
    get
    {
      return new Color(0.8313726f, 0.4156863f, 0.4941176f, 1f);
    }
  }

  public static Color Cobalt
  {
    get
    {
      return new Color(0.1176471f, 0.282353f, 0.5607843f, 1f);
    }
  }

  public static Color NeonPurple
  {
    get
    {
      return new Color(0.7372549f, 0.07450981f, 0.9960784f, 1f);
    }
  }

  public static Color LightTurquoise
  {
    get
    {
      return new Color(0.4941176f, 0.9568627f, 0.8f, 1f);
    }
  }

  public static Color AppleGreen
  {
    get
    {
      return new Color(0.4627451f, 0.8039216f, 0.1490196f, 1f);
    }
  }

  public static Color DullGreen
  {
    get
    {
      return new Color(0.454902f, 0.6509804f, 0.3843137f, 1f);
    }
  }

  public static Color Wine
  {
    get
    {
      return new Color(0.5019608f, 0.003921569f, 0.2470588f, 1f);
    }
  }

  public static Color PowderBlue
  {
    get
    {
      return new Color(0.6941177f, 0.8196079f, 0.9882353f, 1f);
    }
  }

  public static Color OffWhite
  {
    get
    {
      return new Color(1f, 1f, 0.8941177f, 1f);
    }
  }

  public static Color ElectricBlue
  {
    get
    {
      return new Color(0.02352941f, 0.3215686f, 1f, 1f);
    }
  }

  public static Color DarkTurquoise
  {
    get
    {
      return new Color(0.01568628f, 0.3607843f, 0.3529412f, 1f);
    }
  }

  public static Color BluePurple
  {
    get
    {
      return new Color(0.3411765f, 0.1607843f, 0.8078431f, 1f);
    }
  }

  public static Color Azure
  {
    get
    {
      return new Color(0.02352941f, 0.6039216f, 0.9529412f, 1f);
    }
  }

  public static Color BrightRed
  {
    get
    {
      return new Color(1f, 0.0f, 0.05098039f, 1f);
    }
  }

  public static Color PinkishRed
  {
    get
    {
      return new Color(0.945098f, 0.04705882f, 0.2705882f, 1f);
    }
  }

  public static Color CornflowerBlue
  {
    get
    {
      return new Color(0.3176471f, 0.4392157f, 0.8431373f, 1f);
    }
  }

  public static Color LightOlive
  {
    get
    {
      return new Color(0.6745098f, 0.7490196f, 0.4117647f, 1f);
    }
  }

  public static Color Grape
  {
    get
    {
      return new Color(0.4235294f, 0.2039216f, 0.3803922f, 1f);
    }
  }

  public static Color GreyishBlue
  {
    get
    {
      return new Color(0.3686275f, 0.5058824f, 0.6156863f, 1f);
    }
  }

  public static Color PurplishBlue
  {
    get
    {
      return new Color(0.3764706f, 0.1176471f, 0.9764706f, 1f);
    }
  }

  public static Color YellowishGreen
  {
    get
    {
      return new Color(0.6901961f, 0.8666667f, 0.08627451f, 1f);
    }
  }

  public static Color GreenishYellow
  {
    get
    {
      return new Color(0.8039216f, 0.9921569f, 0.007843138f, 1f);
    }
  }

  public static Color MediumBlue
  {
    get
    {
      return new Color(0.172549f, 0.4352941f, 0.7333333f, 1f);
    }
  }

  public static Color DustyRose
  {
    get
    {
      return new Color(0.7529412f, 0.4509804f, 0.4784314f, 1f);
    }
  }

  public static Color LightViolet
  {
    get
    {
      return new Color(0.8392157f, 0.7058824f, 0.9882353f, 1f);
    }
  }

  public static Color MidnightBlue
  {
    get
    {
      return new Color(0.007843138f, 0.0f, 0.2078431f, 1f);
    }
  }

  public static Color BluishPurple
  {
    get
    {
      return new Color(0.4392157f, 0.2313726f, 0.9058824f, 1f);
    }
  }

  public static Color RedOrange
  {
    get
    {
      return new Color(0.9921569f, 0.2352941f, 0.02352941f, 1f);
    }
  }

  public static Color DarkMagenta
  {
    get
    {
      return new Color(0.5882353f, 0.0f, 0.3372549f, 1f);
    }
  }

  public static Color Greenish
  {
    get
    {
      return new Color(0.2509804f, 0.6392157f, 0.4078431f, 1f);
    }
  }

  public static Color OceanBlue
  {
    get
    {
      return new Color(0.01176471f, 0.4431373f, 0.6117647f, 1f);
    }
  }

  public static Color Coral
  {
    get
    {
      return new Color(0.9882353f, 0.3529412f, 0.3137255f, 1f);
    }
  }

  public static Color Cream
  {
    get
    {
      return new Color(1f, 1f, 0.7607843f, 1f);
    }
  }

  public static Color ReddishBrown
  {
    get
    {
      return new Color(0.4980392f, 0.1686275f, 0.03921569f, 1f);
    }
  }

  public static Color BurntSienna
  {
    get
    {
      return new Color(0.6901961f, 0.3058824f, 0.05882353f, 1f);
    }
  }

  public static Color Brick
  {
    get
    {
      return new Color(0.627451f, 0.2117647f, 0.1372549f, 1f);
    }
  }

  public static Color Sage
  {
    get
    {
      return new Color(0.5294118f, 0.682353f, 0.4509804f, 1f);
    }
  }

  public static Color GreyGreen
  {
    get
    {
      return new Color(0.4705882f, 0.6078432f, 0.4509804f, 1f);
    }
  }

  public static Color White
  {
    get
    {
      return new Color(1f, 1f, 1f, 1f);
    }
  }

  public static Color RobinSEggBlue
  {
    get
    {
      return new Color(0.5960785f, 0.9372549f, 0.9764706f, 1f);
    }
  }

  public static Color MossGreen
  {
    get
    {
      return new Color(0.3960784f, 0.5450981f, 0.2196078f, 1f);
    }
  }

  public static Color SteelBlue
  {
    get
    {
      return new Color(0.3529412f, 0.4901961f, 0.6039216f, 1f);
    }
  }

  public static Color Eggplant
  {
    get
    {
      return new Color(0.2196078f, 0.03137255f, 0.2078431f, 1f);
    }
  }

  public static Color LightYellow
  {
    get
    {
      return new Color(1f, 0.9960784f, 0.4784314f, 1f);
    }
  }

  public static Color LeafGreen
  {
    get
    {
      return new Color(0.3607843f, 0.6627451f, 0.01568628f, 1f);
    }
  }

  public static Color LightGrey
  {
    get
    {
      return new Color(0.8470588f, 0.8627451f, 0.8392157f, 1f);
    }
  }

  public static Color Puke
  {
    get
    {
      return new Color(0.6470588f, 0.6470588f, 0.007843138f, 1f);
    }
  }

  public static Color PinkishPurple
  {
    get
    {
      return new Color(0.8392157f, 0.282353f, 0.8431373f, 1f);
    }
  }

  public static Color SeaBlue
  {
    get
    {
      return new Color(0.01568628f, 0.454902f, 0.5843138f, 1f);
    }
  }

  public static Color PalePurple
  {
    get
    {
      return new Color(0.7176471f, 0.5647059f, 0.8313726f, 1f);
    }
  }

  public static Color SlateBlue
  {
    get
    {
      return new Color(0.3568628f, 0.4862745f, 0.6f, 1f);
    }
  }

  public static Color BlueGrey
  {
    get
    {
      return new Color(0.3764706f, 0.4862745f, 0.5568628f, 1f);
    }
  }

  public static Color HunterGreen
  {
    get
    {
      return new Color(0.04313726f, 0.2509804f, 0.03137255f, 1f);
    }
  }

  public static Color Fuchsia
  {
    get
    {
      return new Color(0.9294118f, 0.05098039f, 0.8509804f, 1f);
    }
  }

  public static Color Crimson
  {
    get
    {
      return new Color(0.5490196f, 0.0f, 0.05882353f, 1f);
    }
  }

  public static Color PaleYellow
  {
    get
    {
      return new Color(1f, 1f, 0.5176471f, 1f);
    }
  }

  public static Color Ochre
  {
    get
    {
      return new Color(0.7490196f, 0.5647059f, 0.01960784f, 1f);
    }
  }

  public static Color MustardYellow
  {
    get
    {
      return new Color(0.8235294f, 0.7411765f, 0.03921569f, 1f);
    }
  }

  public static Color LightRed
  {
    get
    {
      return new Color(1f, 0.2784314f, 0.2980392f, 1f);
    }
  }

  public static Color Cerulean
  {
    get
    {
      return new Color(0.01568628f, 0.5215687f, 0.8196079f, 1f);
    }
  }

  public static Color PalePink
  {
    get
    {
      return new Color(1f, 0.8117647f, 0.8627451f, 1f);
    }
  }

  public static Color DeepBlue
  {
    get
    {
      return new Color(0.01568628f, 0.007843138f, 0.4509804f, 1f);
    }
  }

  public static Color Rust
  {
    get
    {
      return new Color(0.6588235f, 0.2352941f, 0.03529412f, 1f);
    }
  }

  public static Color LightTeal
  {
    get
    {
      return new Color(0.5647059f, 0.8941177f, 0.7568628f, 1f);
    }
  }

  public static Color Slate
  {
    get
    {
      return new Color(0.3176471f, 0.3960784f, 0.4470588f, 1f);
    }
  }

  public static Color Goldenrod
  {
    get
    {
      return new Color(0.9803922f, 0.7607843f, 0.01960784f, 1f);
    }
  }

  public static Color DarkYellow
  {
    get
    {
      return new Color(0.8352941f, 0.7137255f, 0.03921569f, 1f);
    }
  }

  public static Color DarkGrey
  {
    get
    {
      return new Color(0.2117647f, 68.0f * (float)Math.E / 857.0f, 68.0f * (float)Math.E / 857.0f, 1f);
    }
  }

  public static Color ArmyGreen
  {
    get
    {
      return new Color(0.2941177f, 0.3647059f, 0.08627451f, 1f);
    }
  }

  public static Color GreyBlue
  {
    get
    {
      return new Color(0.4196078f, 0.5450981f, 0.6431373f, 1f);
    }
  }

  public static Color Seafoam
  {
    get
    {
      return new Color(0.5019608f, 0.9764706f, 0.6784314f, 1f);
    }
  }

  public static Color Puce
  {
    get
    {
      return new Color(0.6470588f, 0.4941176f, 0.3215686f, 1f);
    }
  }

  public static Color SpringGreen
  {
    get
    {
      return new Color(0.6627451f, 0.9764706f, 0.4431373f, 1f);
    }
  }

  public static Color DarkOrange
  {
    get
    {
      return new Color(0.7764706f, 0.3176471f, 0.007843138f, 1f);
    }
  }

  public static Color Sand
  {
    get
    {
      return new Color(0.8862745f, 0.7921569f, 0.4627451f, 1f);
    }
  }

  public static Color PastelGreen
  {
    get
    {
      return new Color(0.6901961f, 1f, 0.6156863f, 1f);
    }
  }

  public static Color Mint
  {
    get
    {
      return new Color(0.6235294f, 0.9960784f, 0.6901961f, 1f);
    }
  }

  public static Color LightOrange
  {
    get
    {
      return new Color(0.9921569f, 0.6666667f, 0.282353f, 1f);
    }
  }

  public static Color BrightPink
  {
    get
    {
      return new Color(0.9960784f, 0.003921569f, 0.6941177f, 1f);
    }
  }

  public static Color Chartreuse
  {
    get
    {
      return new Color(0.7568628f, 0.972549f, 0.03921569f, 1f);
    }
  }

  public static Color DeepPurple
  {
    get
    {
      return new Color(0.2117647f, 0.003921569f, 0.2470588f, 1f);
    }
  }

  public static Color DarkBrown
  {
    get
    {
      return new Color(0.2039216f, 0.1098039f, 0.007843138f, 1f);
    }
  }

  public static Color Taupe
  {
    get
    {
      return new Color(0.7254902f, 0.6352941f, 0.5058824f, 1f);
    }
  }

  public static Color PeaGreen
  {
    get
    {
      return new Color(0.5568628f, 0.6705883f, 0.07058824f, 1f);
    }
  }

  public static Color PukeGreen
  {
    get
    {
      return new Color(0.6039216f, 0.682353f, 0.02745098f, 1f);
    }
  }

  public static Color KellyGreen
  {
    get
    {
      return new Color(0.007843138f, 0.6705883f, 0.1803922f, 1f);
    }
  }

  public static Color SeafoamGreen
  {
    get
    {
      return new Color(0.4784314f, 0.9764706f, 0.6705883f, 1f);
    }
  }

  public static Color BlueGreen
  {
    get
    {
      return new Color(0.07450981f, 0.4941176f, 0.427451f, 1f);
    }
  }

  public static Color Khaki
  {
    get
    {
      return new Color(0.6666667f, 0.6509804f, 0.3843137f, 1f);
    }
  }

  public static Color Burgundy
  {
    get
    {
      return new Color(0.3803922f, 0.0f, 0.1372549f, 1f);
    }
  }

  public static Color DarkTeal
  {
    get
    {
      return new Color(0.003921569f, 0.3019608f, 0.3058824f, 1f);
    }
  }

  public static Color BrickRed
  {
    get
    {
      return new Color(0.5607843f, 0.07843138f, 0.007843138f, 1f);
    }
  }

  public static Color RoyalPurple
  {
    get
    {
      return new Color(0.2941177f, 0.0f, 0.4313726f, 1f);
    }
  }

  public static Color Plum
  {
    get
    {
      return new Color(0.345098f, 0.05882353f, 0.254902f, 1f);
    }
  }

  public static Color MintGreen
  {
    get
    {
      return new Color(0.5607843f, 1f, 0.6235294f, 1f);
    }
  }

  public static Color Gold
  {
    get
    {
      return new Color(0.8588235f, 0.7058824f, 0.04705882f, 1f);
    }
  }

  public static Color BabyBlue
  {
    get
    {
      return new Color(0.6352941f, 0.8117647f, 0.9960784f, 1f);
    }
  }

  public static Color YellowGreen
  {
    get
    {
      return new Color(0.7529412f, 0.9843137f, 0.1764706f, 1f);
    }
  }

  public static Color BrightPurple
  {
    get
    {
      return new Color(0.7450981f, 0.01176471f, 0.9921569f, 1f);
    }
  }

  public static Color DarkRed
  {
    get
    {
      return new Color(0.5176471f, 0.0f, 0.0f, 1f);
    }
  }

  public static Color PaleBlue
  {
    get
    {
      return new Color(0.8156863f, 0.9960784f, 0.9960784f, 1f);
    }
  }

  public static Color GrassGreen
  {
    get
    {
      return new Color(0.2470588f, 0.6078432f, 0.04313726f, 1f);
    }
  }

  public static Color Navy
  {
    get
    {
      return new Color(0.003921569f, 0.08235294f, 0.2431373f, 1f);
    }
  }

  public static Color Aquamarine
  {
    get
    {
      return new Color(0.01568628f, 0.8470588f, 0.6980392f, 1f);
    }
  }

  public static Color BurntOrange
  {
    get
    {
      return new Color(0.7529412f, 0.3058824f, 0.003921569f, 1f);
    }
  }

  public static Color NeonGreen
  {
    get
    {
      return new Color(0.04705882f, 1f, 0.04705882f, 1f);
    }
  }

  public static Color BrightBlue
  {
    get
    {
      return new Color(0.003921569f, 0.3960784f, 0.9882353f, 1f);
    }
  }

  public static Color Rose
  {
    get
    {
      return new Color(0.8117647f, 0.3843137f, 0.4588235f, 1f);
    }
  }

  public static Color LightPink
  {
    get
    {
      return new Color(1f, 0.8196079f, 0.8745098f, 1f);
    }
  }

  public static Color Mustard
  {
    get
    {
      return new Color(0.8078431f, 0.7019608f, 0.003921569f, 1f);
    }
  }

  public static Color Indigo
  {
    get
    {
      return new Color(0.2196078f, 0.007843138f, 0.509804f, 1f);
    }
  }

  public static Color Lime
  {
    get
    {
      return new Color(0.6666667f, 1f, 0.1960784f, 1f);
    }
  }

  public static Color SeaGreen
  {
    get
    {
      return new Color(0.3254902f, 0.9882353f, 0.6313726f, 1f);
    }
  }

  public static Color Periwinkle
  {
    get
    {
      return new Color(0.5568628f, 0.509804f, 0.9960784f, 1f);
    }
  }

  public static Color DarkPink
  {
    get
    {
      return new Color(0.7960784f, 0.254902f, 0.4196078f, 1f);
    }
  }

  public static Color OliveGreen
  {
    get
    {
      return new Color(0.4039216f, 0.4784314f, 0.01568628f, 1f);
    }
  }

  public static Color Peach
  {
    get
    {
      return new Color(1f, 0.6901961f, 0.4862745f, 1f);
    }
  }

  public static Color PaleGreen
  {
    get
    {
      return new Color(0.7803922f, 0.9921569f, 0.7098039f, 1f);
    }
  }

  public static Color LightBrown
  {
    get
    {
      return new Color(0.6784314f, 0.5058824f, 0.3137255f, 1f);
    }
  }

  public static Color HotPink
  {
    get
    {
      return new Color(1f, 0.007843138f, 0.5529412f, 1f);
    }
  }

  public static Color Black
  {
    get
    {
      return new Color(0.0f, 0.0f, 0.0f, 1f);
    }
  }

  public static Color Lilac
  {
    get
    {
      return new Color(0.8078431f, 0.6352941f, 0.9921569f, 1f);
    }
  }

  public static Color NavyBlue
  {
    get
    {
      return new Color(0.0f, 0.06666667f, 0.2745098f, 1f);
    }
  }

  public static Color RoyalBlue
  {
    get
    {
      return new Color(0.01960784f, 0.01568628f, 0.6666667f, 1f);
    }
  }

  public static Color Beige
  {
    get
    {
      return new Color(0.9019608f, 0.854902f, 0.6509804f, 1f);
    }
  }

  public static Color Salmon
  {
    get
    {
      return new Color(1f, 0.4745098f, 0.4235294f, 1f);
    }
  }

  public static Color Olive
  {
    get
    {
      return new Color(0.4313726f, 0.4588235f, 0.05490196f, 1f);
    }
  }

  public static Color Maroon
  {
    get
    {
      return new Color(0.3960784f, 0.0f, 0.1294118f, 1f);
    }
  }

  public static Color BrightGreen
  {
    get
    {
      return new Color(0.003921569f, 1f, 0.02745098f, 1f);
    }
  }

  public static Color DarkPurple
  {
    get
    {
      return new Color(0.2078431f, 0.02352941f, 0.2431373f, 1f);
    }
  }

  public static Color Mauve
  {
    get
    {
      return new Color(0.682353f, 0.4431373f, 0.5058824f, 1f);
    }
  }

  public static Color ForestGreen
  {
    get
    {
      return new Color(0.02352941f, 0.2784314f, 0.04705882f, 1f);
    }
  }

  public static Color Aqua
  {
    get
    {
      return new Color(0.07450981f, 0.9176471f, 0.7882353f, 1f);
    }
  }

  public static Color Cyan
  {
    get
    {
      return new Color(0.0f, 1f, 1f, 1f);
    }
  }

  public static Color Tan
  {
    get
    {
      return new Color(0.8196079f, 0.6980392f, 0.4352941f, 1f);
    }
  }

  public static Color DarkBlue
  {
    get
    {
      return new Color(0.0f, 0.01176471f, 0.3568628f, 1f);
    }
  }

  public static Color Lavender
  {
    get
    {
      return new Color(0.7803922f, 0.6235294f, 0.9372549f, 1f);
    }
  }

  public static Color Turquoise
  {
    get
    {
      return new Color(0.02352941f, 0.7607843f, 0.6745098f, 1f);
    }
  }

  public static Color DarkGreen
  {
    get
    {
      return new Color(0.01176471f, 0.2078431f, 0.0f, 1f);
    }
  }

  public static Color Violet
  {
    get
    {
      return new Color(0.6039216f, 0.05490196f, 0.9176471f, 1f);
    }
  }

  public static Color LightPurple
  {
    get
    {
      return new Color(0.7490196f, 0.4666667f, 0.9647059f, 1f);
    }
  }

  public static Color LimeGreen
  {
    get
    {
      return new Color(0.5372549f, 0.9960784f, 0.01960784f, 1f);
    }
  }

  public static Color Grey
  {
    get
    {
      return new Color(0.572549f, 0.5843138f, 0.5686275f, 1f);
    }
  }

  public static Color SkyBlue
  {
    get
    {
      return new Color(0.4588235f, 0.7333333f, 0.9921569f, 1f);
    }
  }

  public static Color Yellow
  {
    get
    {
      return new Color(1f, 1f, 0.07843138f, 1f);
    }
  }

  public static Color Magenta
  {
    get
    {
      return new Color(0.7607843f, 0.0f, 0.4705882f, 1f);
    }
  }

  public static Color LightGreen
  {
    get
    {
      return new Color(0.5882353f, 0.9764706f, 0.4823529f, 1f);
    }
  }

  public static Color Orange
  {
    get
    {
        return XKCDColors.Blue;
  //    return new Color(0.9764706f, 0.4509804f, 0.02352941f, 1f);
    }
  }

  public static Color Teal
  {
    get
    {
      return new Color(0.007843138f, 0.5764706f, 0.5254902f, 1f);
    }
  }

  public static Color LightBlue
  {
    get
    {
      return new Color(0.5843138f, 0.8156863f, 0.9882353f, 1f);
    }
  }

  public static Color Red
  {
    get
    {
      return new Color(0.8980392f, 0.0f, 0.0f, 1f);
    }
  }

  public static Color Brown
  {
    get
    {
      return new Color(0.3960784f, 68.0f * (float)Math.E / 857.0f, 0.0f, 1f);
    }
  }

  public static Color Pink
  {
    get
    {
      return new Color(1f, 0.5058824f, 0.7529412f, 1f);
    }
  }

  public static Color Blue
  {
    get
    {
      return new Color(0.01176471f, 0.2627451f, 0.8745098f, 1f);
    }
  }

  public static Color Green
  {
    get
    {
      return new Color(0.08235294f, 0.6901961f, 0.1019608f, 1f);
    }
  }

  public static Color Purple
  {
    get
    {
      return new Color(0.4941176f, 0.1176471f, 0.6117647f, 1f);
    }
  }

  public static Color A(this Color c, float a)
  {
    c.a = a;
    return c;
  }

  public static Color32 A(this Color32 c, byte a)
  {
    c.a = a;
    return c;
  }

  public class ColorTranslator
  {
    public static UnityEngine.Color FromHtml(string hexString)
    {
        return new UnityEngine.Color((float)Convert.ToInt32(hexString.Substring(1, 2), 16) / (float)byte.MaxValue, (float)Convert.ToInt32(hexString.Substring(3, 2), 16) / (float)byte.MaxValue, (float)Convert.ToInt32(hexString.Substring(5, 2), 16) / (float)byte.MaxValue, 1f);
    }

    public static string ToHex(UnityEngine.Color c)
    {
        String rtn = String.Empty;
        try
        {
            rtn = "#" + c.r.ToString("X2") + c.g.ToString("X2") + c.b.ToString("X2");
        }
        catch (Exception ex)
        {
            return "#FF00FF";
        }

        return rtn;  
    }
  }

  public class HexFormat
  {
    public static string KSPBadassGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.KSPBadassGreen);
      } 
    }

    public static string KSPNotSoGoodOrange
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.KSPNotSoGoodOrange);
      }
    }

    public static string KSPUIGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.KSPUIGrey);
      }
    }

    public static string KSPUnnamedCyan
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.KSPUnnamedCyan);
      }
    }

    public static string KSPNeutralUIGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.KSPNeutralUIGrey);
      }
    }

    public static string CloudyBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.CloudyBlue);
      }
    }

    public static string DarkPastelGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkPastelGreen);
      }
    }

    public static string Dust
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Dust);
      }
    }

    public static string ElectricLime
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.ElectricLime);
      }
    }

    public static string FreshGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.FreshGreen);
      }
    }

    public static string LightEggplant
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightEggplant);
      }
    }

    public static string NastyGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.NastyGreen);
      }
    }

    public static string ReallyLightBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.ReallyLightBlue);
      }
    }

    public static string Tea
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Tea);
      }
    }

    public static string WarmPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.WarmPurple);
      }
    }

    public static string YellowishTan
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.YellowishTan);
      }
    }

    public static string Cement
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Cement);
      }
    }

    public static string DarkGrassGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkGrassGreen);
      }
    }

    public static string DustyTeal
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DustyTeal);
      }
    }

    public static string GreyTeal
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GreyTeal);
      }
    }

    public static string MacaroniAndCheese
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.MacaroniAndCheese);
      }
    }

    public static string PinkishTan
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PinkishTan);
      }
    }

    public static string Spruce
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Spruce);
      }
    }

    public static string StrongBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.StrongBlue);
      }
    }

    public static string ToxicGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.ToxicGreen);
      }
    }

    public static string WindowsBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.WindowsBlue);
      }
    }

    public static string BlueBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BlueBlue);
      }
    }

    public static string BlueWithAHintOfPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BlueWithAHintOfPurple);
      }
    }

    public static string Booger
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Booger);
      }
    }

    public static string BrightSeaGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BrightSeaGreen);
      }
    }

    public static string DarkGreenBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkGreenBlue);
      }
    }

    public static string DeepTurquoise
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DeepTurquoise);
      }
    }

    public static string GreenTeal
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GreenTeal);
      }
    }

    public static string StrongPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.StrongPink);
      }
    }

    public static string Bland
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Bland);
      }
    }

    public static string DeepAqua
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DeepAqua);
      }
    }

    public static string LavenderPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LavenderPink);
      }
    }

    public static string LightMossGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightMossGreen);
      }
    }

    public static string LightSeafoamGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightSeafoamGreen);
      }
    }

    public static string OliveYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.OliveYellow);
      }
    }

    public static string PigPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PigPink);
      }
    }

    public static string DeepLilac
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DeepLilac);
      }
    }

    public static string Desert
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Desert);
      }
    }

    public static string DustyLavender
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DustyLavender);
      }
    }

    public static string PurpleyGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PurpleyGrey);
      }
    }

    public static string Purply
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Purply);
      }
    }

    public static string CandyPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.CandyPink);
      }
    }

    public static string LightPastelGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightPastelGreen);
      }
    }

    public static string BoringGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BoringGreen);
      }
    }

    public static string KiwiGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.KiwiGreen);
      }
    }

    public static string LightGreyGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightGreyGreen);
      }
    }

    public static string OrangePink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.OrangePink);
      }
    }

    public static string TeaGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.TeaGreen);
      }
    }

    public static string VeryLightBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.VeryLightBrown);
      }
    }

    public static string EggShell
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.EggShell);
      }
    }

    public static string EggplantPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.EggplantPurple);
      }
    }

    public static string PowderPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PowderPink);
      }
    }

    public static string ReddishGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.ReddishGrey);
      }
    }

    public static string BabyShitBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BabyShitBrown);
      }
    }

    public static string Liliac
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Liliac);
      }
    }

    public static string StormyBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.StormyBlue);
      }
    }

    public static string UglyBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.UglyBrown);
      }
    }

    public static string Custard
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Custard);
      }
    }

    public static string DarkishPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkishPink);
      }
    }

    public static string DeepBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DeepBrown);
      }
    }

    public static string GreenishBeige
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GreenishBeige);
      }
    }

    public static string Manilla
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Manilla);
      }
    }

    public static string OffBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.OffBlue);
      }
    }

    public static string BattleshipGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BattleshipGrey);
      }
    }

    public static string BrownyGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BrownyGreen);
      }
    }

    public static string Bruise
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Bruise);
      }
    }

    public static string KelleyGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.KelleyGreen);
      }
    }

    public static string SicklyYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SicklyYellow);
      }
    }

    public static string SunnyYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SunnyYellow);
      }
    }

    public static string Azul
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Azul);
      }
    }

    public static string Darkgreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Darkgreen);
      }
    }

    public static string Green_Yellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Green_Yellow);
      }
    }

    public static string Lichen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Lichen);
      }
    }

    public static string LightLightGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightLightGreen);
      }
    }

    public static string PaleGold
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PaleGold);
      }
    }

    public static string SunYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SunYellow);
      }
    }

    public static string TanGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.TanGreen);
      }
    }

    public static string Burple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Burple);
      }
    }

    public static string Butterscotch
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Butterscotch);
      }
    }

    public static string Toupe
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Toupe);
      }
    }

    public static string DarkCream
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkCream);
      }
    }

    public static string IndianRed
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.IndianRed);
      }
    }

    public static string LightLavendar
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightLavendar);
      }
    }

    public static string PoisonGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PoisonGreen);
      }
    }

    public static string BabyPukeGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BabyPukeGreen);
      }
    }

    public static string BrightYellowGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BrightYellowGreen);
      }
    }

    public static string CharcoalGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.CharcoalGrey);
      }
    }

    public static string Squash
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Squash);
      }
    }

    public static string Cinnamon
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Cinnamon);
      }
    }

    public static string LightPeaGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightPeaGreen);
      }
    }

    public static string RadioactiveGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RadioactiveGreen);
      }
    }

    public static string RawSienna
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RawSienna);
      }
    }

    public static string BabyPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BabyPurple);
      }
    }

    public static string Cocoa
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Cocoa);
      }
    }

    public static string LightRoyalBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightRoyalBlue);
      }
    }

    public static string Orangeish
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Orangeish);
      }
    }

    public static string RustBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RustBrown);
      }
    }

    public static string SandBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SandBrown);
      }
    }

    public static string Swamp
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Swamp);
      }
    }

    public static string TealishGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.TealishGreen);
      }
    }

    public static string BurntSiena
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BurntSiena);
      }
    }

    public static string Camo
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Camo);
      }
    }

    public static string DuskBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DuskBlue);
      }
    }

    public static string Fern
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Fern);
      }
    }

    public static string OldRose
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.OldRose);
      }
    }

    public static string PaleLightGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PaleLightGreen);
      }
    }

    public static string PeachyPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PeachyPink);
      }
    }

    public static string RosyPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RosyPink);
      }
    }

    public static string LightBluishGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightBluishGreen);
      }
    }

    public static string LightBrightGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightBrightGreen);
      }
    }

    public static string LightNeonGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightNeonGreen);
      }
    }

    public static string LightSeafoam
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightSeafoam);
      }
    }

    public static string TiffanyBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.TiffanyBlue);
      }
    }

    public static string WashedOutGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.WashedOutGreen);
      }
    }

    public static string BrownyOrange
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BrownyOrange);
      }
    }

    public static string NiceBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.NiceBlue);
      }
    }

    public static string Sapphire
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Sapphire);
      }
    }

    public static string GreyishTeal
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GreyishTeal);
      }
    }

    public static string OrangeyYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.OrangeyYellow);
      }
    }

    public static string Parchment
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Parchment);
      }
    }

    public static string Straw
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Straw);
      }
    }

    public static string VeryDarkBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.VeryDarkBrown);
      }
    }

    public static string Terracota
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Terracota);
      }
    }

    public static string UglyBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.UglyBlue);
      }
    }

    public static string ClearBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.ClearBlue);
      }
    }

    public static string Creme
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Creme);
      }
    }

    public static string FoamGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.FoamGreen);
      }
    }

    public static string Grey_Green
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Grey_Green);
      }
    }

    public static string LightGold
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightGold);
      }
    }

    public static string SeafoamBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SeafoamBlue);
      }
    }

    public static string Topaz
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Topaz);
      }
    }

    public static string VioletPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.VioletPink);
      }
    }

    public static string Wintergreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Wintergreen);
      }
    }

    public static string YellowTan
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.YellowTan);
      }
    }

    public static string DarkFuchsia
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkFuchsia);
      }
    }

    public static string IndigoBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.IndigoBlue);
      }
    }

    public static string LightYellowishGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightYellowishGreen);
      }
    }

    public static string PaleMagenta
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PaleMagenta);
      }
    }

    public static string RichPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RichPurple);
      }
    }

    public static string SunflowerYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SunflowerYellow);
      }
    }

    public static string Green_Blue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Green_Blue);
      }
    }

    public static string Leather
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Leather);
      }
    }

    public static string RacingGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RacingGreen);
      }
    }

    public static string VividPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.VividPurple);
      }
    }

    public static string DarkRoyalBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkRoyalBlue);
      }
    }

    public static string Hazel
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Hazel);
      }
    }

    public static string MutedPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.MutedPink);
      }
    }

    public static string BoogerGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BoogerGreen);
      }
    }

    public static string Canary
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Canary);
      }
    }

    public static string CoolGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.CoolGrey);
      }
    }

    public static string DarkTaupe
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkTaupe);
      }
    }

    public static string DarkishPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkishPurple);
      }
    }

    public static string TrueGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.TrueGreen);
      }
    }

    public static string CoralPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.CoralPink);
      }
    }

    public static string DarkSage
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkSage);
      }
    }

    public static string DarkSlateBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkSlateBlue);
      }
    }

    public static string FlatBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.FlatBlue);
      }
    }

    public static string Mushroom
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Mushroom);
      }
    }

    public static string RichBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RichBlue);
      }
    }

    public static string DirtyPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DirtyPurple);
      }
    }

    public static string Greenblue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Greenblue);
      }
    }

    public static string IckyGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.IckyGreen);
      }
    }

    public static string LightKhaki
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightKhaki);
      }
    }

    public static string WarmBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.WarmBlue);
      }
    }

    public static string DarkHotPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkHotPink);
      }
    }

    public static string DeepSeaBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DeepSeaBlue);
      }
    }

    public static string Carmine
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Carmine);
      }
    }

    public static string DarkYellowGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkYellowGreen);
      }
    }

    public static string PalePeach
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PalePeach);
      }
    }

    public static string PlumPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PlumPurple);
      }
    }

    public static string GoldenRod
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GoldenRod);
      }
    }

    public static string NeonRed
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.NeonRed);
      }
    }

    public static string OldPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.OldPink);
      }
    }

    public static string VeryPaleBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.VeryPaleBlue);
      }
    }

    public static string BloodOrange
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BloodOrange);
      }
    }

    public static string Grapefruit
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Grapefruit);
      }
    }

    public static string SandYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SandYellow);
      }
    }

    public static string ClayBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.ClayBrown);
      }
    }

    public static string DarkBlueGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkBlueGrey);
      }
    }

    public static string FlatGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.FlatGreen);
      }
    }

    public static string LightGreenBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightGreenBlue);
      }
    }

    public static string WarmPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.WarmPink);
      }
    }

    public static string DodgerBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DodgerBlue);
      }
    }

    public static string GrossGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GrossGreen);
      }
    }

    public static string Ice
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Ice);
      }
    }

    public static string MetallicBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.MetallicBlue);
      }
    }

    public static string PaleSalmon
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PaleSalmon);
      }
    }

    public static string SapGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SapGreen);
      }
    }

    public static string Algae
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Algae);
      }
    }

    public static string BlueyGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BlueyGrey);
      }
    }

    public static string GreenyGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GreenyGrey);
      }
    }

    public static string HighlighterGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.HighlighterGreen);
      }
    }

    public static string LightLightBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightLightBlue);
      }
    }

    public static string LightMint
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightMint);
      }
    }

    public static string RawUmber
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RawUmber);
      }
    }

    public static string VividBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.VividBlue);
      }
    }

    public static string DeepLavender
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DeepLavender);
      }
    }

    public static string DullTeal
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DullTeal);
      }
    }

    public static string LightGreenishBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightGreenishBlue);
      }
    }

    public static string MudGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.MudGreen);
      }
    }

    public static string Pinky
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Pinky);
      }
    }

    public static string RedWine
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RedWine);
      }
    }

    public static string ShitGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.ShitGreen);
      }
    }

    public static string TanBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.TanBrown);
      }
    }

    public static string Darkblue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Darkblue);
      }
    }

    public static string Rosa
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Rosa);
      }
    }

    public static string Lipstick
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Lipstick);
      }
    }

    public static string PaleMauve
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PaleMauve);
      }
    }

    public static string Claret
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Claret);
      }
    }

    public static string Dandelion
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Dandelion);
      }
    }

    public static string Orangered
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Orangered);
      }
    }

    public static string PoopGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PoopGreen);
      }
    }

    public static string Ruby
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Ruby);
      }
    }

    public static string Dark
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Dark);
      }
    }

    public static string GreenishTurquoise
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GreenishTurquoise);
      }
    }

    public static string PastelRed
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PastelRed);
      }
    }

    public static string PissYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PissYellow);
      }
    }

    public static string BrightCyan
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BrightCyan);
      }
    }

    public static string DarkCoral
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkCoral);
      }
    }

    public static string AlgaeGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.AlgaeGreen);
      }
    }

    public static string DarkishRed
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkishRed);
      }
    }

    public static string ReddyBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.ReddyBrown);
      }
    }

    public static string BlushPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BlushPink);
      }
    }

    public static string CamouflageGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.CamouflageGreen);
      }
    }

    public static string LawnGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LawnGreen);
      }
    }

    public static string Putty
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Putty);
      }
    }

    public static string VibrantBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.VibrantBlue);
      }
    }

    public static string DarkSand
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkSand);
      }
    }

    public static string Purple_Blue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Purple_Blue);
      }
    }

    public static string Saffron
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Saffron);
      }
    }

    public static string Twilight
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Twilight);
      }
    }

    public static string WarmBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.WarmBrown);
      }
    }

    public static string Bluegrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Bluegrey);
      }
    }

    public static string BubbleGumPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BubbleGumPink);
      }
    }

    public static string DuckEggBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DuckEggBlue);
      }
    }

    public static string GreenishCyan
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GreenishCyan);
      }
    }

    public static string Petrol
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Petrol);
      }
    }

    public static string Royal
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Royal);
      }
    }

    public static string Butter
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Butter);
      }
    }

    public static string DustyOrange
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DustyOrange);
      }
    }

    public static string OffYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.OffYellow);
      }
    }

    public static string PaleOliveGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PaleOliveGreen);
      }
    }

    public static string Orangish
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Orangish);
      }
    }
      /*
    public static string Leaf
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347412);
      }
    }

    public static string LightBlueGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347427);
      }
    }

    public static string DriedBlood
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347442);
      }
    }

    public static string LightishPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347457);
      }
    }

    public static string RustyRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347472);
      }
    }

    public static string LavenderBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347487);
      }
    }

    public static string LightGrassGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347502);
      }
    }

    public static string LightMintGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347517);
      }
    }

    public static string Sunflower
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347532);
      }
    }

    public static string Velvet
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347547);
      }
    }

    public static string BrickOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347562);
      }
    }

    public static string LightishRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347577);
      }
    }

    public static string PureBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347592);
      }
    }

    public static string TwilightBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347607);
      }
    }

    public static string VioletRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347622);
      }
    }

    public static string YellowyBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347637);
      }
    }

    public static string Carnation
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347652);
      }
    }

    public static string MuddyYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347667);
      }
    }

    public static string DarkSeafoamGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347682);
      }
    }

    public static string DeepRose
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347697);
      }
    }

    public static string DustyRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347712);
      }
    }

    public static string Grey_Blue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347727);
      }
    }

    public static string LemonLime
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347742);
      }
    }

    public static string Purple_Pink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347757);
      }
    }

    public static string BrownYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347772);
      }
    }

    public static string PurpleBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347787);
      }
    }

    public static string Wisteria
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347802);
      }
    }

    public static string BananaYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347817);
      }
    }

    public static string LipstickRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347832);
      }
    }

    public static string WaterBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347847);
      }
    }

    public static string BrownGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347862);
      }
    }

    public static string VibrantPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347877);
      }
    }

    public static string BabyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347892);
      }
    }

    public static string BarfGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347907);
      }
    }

    public static string EggshellBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347922);
      }
    }

    public static string SandyYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347937);
      }
    }

    public static string CoolGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347952);
      }
    }

    public static string Pale
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347967);
      }
    }

    public static string Blue_Grey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347982);
      }
    }

    public static string HotMagenta
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a347997);
      }
    }

    public static string Greyblue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348012);
      }
    }

    public static string Purpley
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348027);
      }
    }

    public static string BabyShitGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348042);
      }
    }

    public static string BrownishPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348057);
      }
    }

    public static string DarkAquamarine
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348072);
      }
    }

    public static string Diarrhea
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348087);
      }
    }

    public static string LightMustard
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348102);
      }
    }

    public static string PaleSkyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348117);
      }
    }

    public static string TurtleGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348132);
      }
    }

    public static string BrightOlive
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348147);
      }
    }

    public static string DarkGreyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348162);
      }
    }

    public static string GreenyBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348177);
      }
    }

    public static string LemonGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348192);
      }
    }

    public static string LightPeriwinkle
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348207);
      }
    }

    public static string SeaweedGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348222);
      }
    }

    public static string SunshineYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348237);
      }
    }

    public static string UglyPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348252);
      }
    }

    public static string MediumPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348267);
      }
    }

    public static string PukeBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348282);
      }
    }

    public static string VeryLightPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348297);
      }
    }

    public static string Viridian
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348312);
      }
    }

    public static string Bile
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348327);
      }
    }

    public static string FadedYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348342);
      }
    }

    public static string VeryPaleGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348357);
      }
    }

    public static string VibrantGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348372);
      }
    }

    public static string BrightLime
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348387);
      }
    }

    public static string Spearmint
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348402);
      }
    }

    public static string LightAquamarine
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348417);
      }
    }

    public static string LightSage
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348432);
      }
    }

    public static string Yellowgreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348447);
      }
    }

    public static string BabyPoo
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348462);
      }
    }

    public static string DarkSeafoam
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348477);
      }
    }

    public static string DeepTeal
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348492);
      }
    }

    public static string Heather
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348507);
      }
    }

    public static string RustOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348522);
      }
    }

    public static string DirtyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348537);
      }
    }

    public static string FernGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348552);
      }
    }

    public static string BrightLilac
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348567);
      }
    }

    public static string WeirdGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348582);
      }
    }

    public static string PeacockBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348597);
      }
    }

    public static string AvocadoGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348612);
      }
    }

    public static string FadedOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348627);
      }
    }

    public static string GrapePurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348642);
      }
    }

    public static string HotGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348657);
      }
    }

    public static string LimeYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348672);
      }
    }

    public static string Mango
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348687);
      }
    }

    public static string Shamrock
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348702);
      }
    }

    public static string Bubblegum
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348717);
      }
    }

    public static string PurplishBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348732);
      }
    }

    public static string VomitYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348747);
      }
    }

    public static string PaleCyan
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348762);
      }
    }

    public static string KeyLime
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348777);
      }
    }

    public static string TomatoRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348792);
      }
    }

    public static string Lightgreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348807);
      }
    }

    public static string Merlot
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348822);
      }
    }

    public static string NightBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348837);
      }
    }

    public static string PurpleishPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348852);
      }
    }

    public static string Apple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348867);
      }
    }

    public static string BabyPoopGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348882);
      }
    }

    public static string GreenApple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348897);
      }
    }

    public static string Heliotrope
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348912);
      }
    }

    public static string Yellow_Green
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348927);
      }
    }

    public static string AlmostBlack
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348942);
      }
    }

    public static string CoolBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348957);
      }
    }

    public static string LeafyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348972);
      }
    }

    public static string MustardBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a348987);
      }
    }

    public static string Dusk
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349002);
      }
    }

    public static string DullBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349017);
      }
    }

    public static string FrogGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349032);
      }
    }

    public static string VividGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349047);
      }
    }

    public static string BrightLightGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349062);
      }
    }

    public static string FluroGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349077);
      }
    }

    public static string Kiwi
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349092);
      }
    }

    public static string Seaweed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349107);
      }
    }

    public static string NavyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349122);
      }
    }

    public static string UltramarineBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349137);
      }
    }

    public static string Iris
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349152);
      }
    }

    public static string PastelOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349167);
      }
    }

    public static string YellowishOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349182);
      }
    }

    public static string Perrywinkle
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349197);
      }
    }

    public static string Tealish
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349212);
      }
    }

    public static string DarkPlum
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349227);
      }
    }

    public static string Pear
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349242);
      }
    }

    public static string PinkishOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349257);
      }
    }

    public static string MidnightPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349272);
      }
    }

    public static string LightUrple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349287);
      }
    }

    public static string DarkMint
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349302);
      }
    }

    public static string GreenishTan
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349317);
      }
    }

    public static string LightBurgundy
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349332);
      }
    }

    public static string TurquoiseBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349347);
      }
    }

    public static string UglyPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349362);
      }
    }

    public static string Sandy
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349377);
      }
    }

    public static string ElectricPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349392);
      }
    }

    public static string MutedPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349407);
      }
    }

    public static string MidGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349422);
      }
    }

    public static string Greyish
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349437);
      }
    }

    public static string NeonYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349452);
      }
    }

    public static string Banana
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349467);
      }
    }

    public static string CarnationPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349482);
      }
    }

    public static string Tomato
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349497);
      }
    }

    public static string Sea
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349512);
      }
    }

    public static string MuddyBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349527);
      }
    }

    public static string TurquoiseGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349542);
      }
    }

    public static string Buff
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349557);
      }
    }

    public static string Fawn
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349572);
      }
    }

    public static string MutedBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349587);
      }
    }

    public static string PaleRose
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349602);
      }
    }

    public static string DarkMintGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349617);
      }
    }

    public static string Amethyst
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349632);
      }
    }

    public static string Blue_Green
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349647);
      }
    }

    public static string Chestnut
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349662);
      }
    }

    public static string SickGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349677);
      }
    }

    public static string Pea
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349692);
      }
    }

    public static string RustyOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349707);
      }
    }

    public static string Stone
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349722);
      }
    }

    public static string RoseRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349737);
      }
    }

    public static string PaleAqua
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349752);
      }
    }

    public static string DeepOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349767);
      }
    }

    public static string Earth
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349782);
      }
    }

    public static string MossyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349797);
      }
    }

    public static string GrassyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349812);
      }
    }

    public static string PaleLimeGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349827);
      }
    }

    public static string LightGreyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349842);
      }
    }

    public static string PaleGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349857);
      }
    }

    public static string Asparagus
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349872);
      }
    }

    public static string Blueberry
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349887);
      }
    }

    public static string PurpleRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349902);
      }
    }

    public static string PaleLime
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349917);
      }
    }

    public static string GreenishTeal
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349932);
      }
    }

    public static string Caramel
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349947);
      }
    }

    public static string DeepMagenta
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349962);
      }
    }

    public static string LightPeach
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349977);
      }
    }

    public static string MilkChocolate
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a349992);
      }
    }

    public static string Ocher
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350007);
      }
    }

    public static string OffGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350022);
      }
    }

    public static string PurplyPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350037);
      }
    }

    public static string Lightblue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350052);
      }
    }

    public static string DuskyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350067);
      }
    }

    public static string Golden
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350082);
      }
    }

    public static string LightBeige
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350097);
      }
    }

    public static string ButterYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350112);
      }
    }

    public static string DuskyPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350127);
      }
    }

    public static string FrenchBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350142);
      }
    }

    public static string UglyYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350157);
      }
    }

    public static string GreenyYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350172);
      }
    }

    public static string OrangishRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350187);
      }
    }

    public static string ShamrockGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350202);
      }
    }

    public static string OrangishBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350217);
      }
    }

    public static string TreeGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350232);
      }
    }

    public static string DeepViolet
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350247);
      }
    }

    public static string Gunmetal
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350262);
      }
    }

    public static string Blue_Purple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350277);
      }
    }

    public static string Cherry
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350292);
      }
    }

    public static string SandyBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350307);
      }
    }

    public static string WarmGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350322);
      }
    }

    public static string DarkIndigo
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350337);
      }
    }

    public static string Midnight
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350352);
      }
    }

    public static string BlueyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350367);
      }
    }

    public static string GreyPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350382);
      }
    }

    public static string SoftPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350397);
      }
    }

    public static string Blood
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350412);
      }
    }

    public static string BrownRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350427);
      }
    }

    public static string MediumGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350442);
      }
    }

    public static string Berry
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350457);
      }
    }

    public static string Poo
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350472);
      }
    }

    public static string PurpleyPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350487);
      }
    }

    public static string LightSalmon
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350502);
      }
    }

    public static string Snot
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350517);
      }
    }

    public static string EasterPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350532);
      }
    }

    public static string LightYellowGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350547);
      }
    }

    public static string DarkNavyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350562);
      }
    }

    public static string Drab
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350577);
      }
    }

    public static string LightRose
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350592);
      }
    }

    public static string Rouge
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350607);
      }
    }

    public static string PurplishRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350622);
      }
    }

    public static string SlimeGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350637);
      }
    }

    public static string BabyPoop
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350652);
      }
    }

    public static string IrishGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350667);
      }
    }

    public static string Pink_Purple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350682);
      }
    }

    public static string DarkNavy
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350697);
      }
    }

    public static string GreenyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350712);
      }
    }

    public static string LightPlum
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350727);
      }
    }

    public static string PinkishGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350742);
      }
    }

    public static string DirtyOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350757);
      }
    }

    public static string RustRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350772);
      }
    }

    public static string PaleLilac
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350787);
      }
    }

    public static string OrangeyRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350802);
      }
    }

    public static string PrimaryBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350817);
      }
    }

    public static string KermitGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350832);
      }
    }

    public static string BrownishPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350847);
      }
    }

    public static string MurkyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350862);
      }
    }

    public static string Wheat
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350877);
      }
    }

    public static string VeryDarkPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350892);
      }
    }

    public static string BottleGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350907);
      }
    }

    public static string Watermelon
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350922);
      }
    }

    public static string DeepSkyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350937);
      }
    }

    public static string FireEngineRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350952);
      }
    }

    public static string YellowOchre
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350967);
      }
    }

    public static string PumpkinOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350982);
      }
    }

    public static string PaleOlive
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a350997);
      }
    }

    public static string LightLilac
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351012);
      }
    }

    public static string LightishGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351027);
      }
    }

    public static string CarolinaBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351042);
      }
    }

    public static string Mulberry
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351057);
      }
    }

    public static string ShockingPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351072);
      }
    }

    public static string Auburn
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351087);
      }
    }

    public static string BrightLimeGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351102);
      }
    }

    public static string Celadon
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351117);
      }
    }

    public static string PinkishBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351132);
      }
    }

    public static string PooBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351147);
      }
    }

    public static string BrightSkyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351162);
      }
    }

    public static string Celery
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351177);
      }
    }

    public static string DirtBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351192);
      }
    }

    public static string Strawberry
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351207);
      }
    }

    public static string DarkLime
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351222);
      }
    }

    public static string Copper
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351237);
      }
    }

    public static string MediumBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351252);
      }
    }

    public static string MutedGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351267);
      }
    }

    public static string RobinSEgg
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351282);
      }
    }

    public static string BrightAqua
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351297);
      }
    }

    public static string BrightLavender
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351312);
      }
    }

    public static string Ivory
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351327);
      }
    }

    public static string VeryLightPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351342);
      }
    }

    public static string LightNavy
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351357);
      }
    }

    public static string PinkRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351372);
      }
    }

    public static string OliveBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351387);
      }
    }

    public static string PoopBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351402);
      }
    }

    public static string MustardGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351417);
      }
    }

    public static string OceanGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351432);
      }
    }

    public static string VeryDarkBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351447);
      }
    }

    public static string DustyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351462);
      }
    }

    public static string LightNavyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351477);
      }
    }

    public static string MintyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351492);
      }
    }

    public static string Adobe
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351507);
      }
    }

    public static string Barney
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351522);
      }
    }

    public static string JadeGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351537);
      }
    }

    public static string BrightLightBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351552);
      }
    }

    public static string LightLime
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351567);
      }
    }

    public static string DarkKhaki
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351582);
      }
    }

    public static string OrangeYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351597);
      }
    }

    public static string Ocre
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351612);
      }
    }

    public static string Maize
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351627);
      }
    }

    public static string FadedPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351642);
      }
    }

    public static string BritishRacingGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351657);
      }
    }

    public static string Sandstone
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351672);
      }
    }

    public static string MudBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351687);
      }
    }

    public static string LightSeaGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351702);
      }
    }

    public static string RobinEggBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351717);
      }
    }

    public static string AquaMarine
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351732);
      }
    }

    public static string DarkSeaGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351747);
      }
    }

    public static string SoftPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351762);
      }
    }

    public static string OrangeyBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351777);
      }
    }

    public static string CherryRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351792);
      }
    }

    public static string BurntYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351807);
      }
    }

    public static string BrownishGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351822);
      }
    }

    public static string Camel
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351837);
      }
    }

    public static string PurplishGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351852);
      }
    }

    public static string Marine
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351867);
      }
    }

    public static string GreyishPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351882);
      }
    }

    public static string PaleTurquoise
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351897);
      }
    }

    public static string PastelYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351912);
      }
    }

    public static string BlueyPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351927);
      }
    }

    public static string CanaryYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351942);
      }
    }

    public static string FadedRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351957);
      }
    }

    public static string Sepia
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351972);
      }
    }

    public static string Coffee
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a351987);
      }
    }

    public static string BrightMagenta
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352002);
      }
    }

    public static string Mocha
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352017);
      }
    }

    public static string Ecru
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352032);
      }
    }

    public static string Purpleish
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352047);
      }
    }

    public static string Cranberry
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352062);
      }
    }

    public static string DarkishGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352077);
      }
    }

    public static string BrownOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352092);
      }
    }

    public static string DuskyRose
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352107);
      }
    }

    public static string Melon
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352122);
      }
    }

    public static string SicklyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352137);
      }
    }

    public static string Silver
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352152);
      }
    }

    public static string PurplyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352167);
      }
    }

    public static string PurpleishBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352182);
      }
    }

    public static string HospitalGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352197);
      }
    }

    public static string ShitBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352212);
      }
    }

    public static string MidBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352227);
      }
    }

    public static string Amber
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352242);
      }
    }

    public static string EasterGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352257);
      }
    }

    public static string SoftBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352272);
      }
    }

    public static string CeruleanBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352287);
      }
    }

    public static string GoldenBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352302);
      }
    }

    public static string BrightTurquoise
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352317);
      }
    }

    public static string RedPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352332);
      }
    }

    public static string RedPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352347);
      }
    }

    public static string GreyishBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352362);
      }
    }

    public static string Vermillion
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352377);
      }
    }

    public static string Russet
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352392);
      }
    }

    public static string SteelGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352407);
      }
    }

    public static string LighterPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352422);
      }
    }

    public static string BrightViolet
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352437);
      }
    }

    public static string PrussianBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352452);
      }
    }

    public static string SlateGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352467);
      }
    }

    public static string DirtyPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352482);
      }
    }

    public static string DarkBlueGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352497);
      }
    }

    public static string Pine
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352512);
      }
    }

    public static string YellowyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352527);
      }
    }

    public static string DarkGold
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352542);
      }
    }

    public static string Bluish
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352557);
      }
    }

    public static string DarkishBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352572);
      }
    }

    public static string DullRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352587);
      }
    }

    public static string PinkyRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352602);
      }
    }

    public static string Bronze
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352617);
      }
    }

    public static string PaleTeal
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352632);
      }
    }

    public static string MilitaryGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352647);
      }
    }

    public static string BarbiePink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352662);
      }
    }

    public static string BubblegumPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352677);
      }
    }

    public static string PeaSoupGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352692);
      }
    }

    public static string DarkMustard
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352707);
      }
    }

    public static string Shit
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352722);
      }
    }

    public static string MediumPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352737);
      }
    }

    public static string VeryDarkGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352752);
      }
    }

    public static string Dirt
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352767);
      }
    }

    public static string DuskyPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352782);
      }
    }

    public static string RedViolet
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352797);
      }
    }

    public static string LemonYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352812);
      }
    }

    public static string Pistachio
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352827);
      }
    }

    public static string DullYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352842);
      }
    }

    public static string DarkLimeGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352857);
      }
    }

    public static string DenimBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352872);
      }
    }

    public static string TealBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352887);
      }
    }

    public static string LightishBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352902);
      }
    }

    public static string PurpleyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352917);
      }
    }

    public static string LightIndigo
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352932);
      }
    }

    public static string SwampGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352947);
      }
    }

    public static string BrownGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352962);
      }
    }

    public static string DarkMaroon
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352977);
      }
    }

    public static string HotPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a352992);
      }
    }

    public static string DarkForestGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353007);
      }
    }

    public static string FadedBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353022);
      }
    }

    public static string DrabGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353037);
      }
    }

    public static string LightLimeGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353052);
      }
    }

    public static string SnotGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353067);
      }
    }

    public static string Yellowish
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353082);
      }
    }

    public static string LightBlueGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353097);
      }
    }

    public static string Bordeaux
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353112);
      }
    }

    public static string LightMauve
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353127);
      }
    }

    public static string Ocean
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353142);
      }
    }

    public static string Marigold
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353157);
      }
    }

    public static string MuddyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353172);
      }
    }

    public static string DullOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353187);
      }
    }

    public static string Steel
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353202);
      }
    }

    public static string ElectricPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353217);
      }
    }

    public static string FluorescentGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353232);
      }
    }

    public static string YellowishBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353247);
      }
    }

    public static string Blush
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353262);
      }
    }

    public static string SoftGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353277);
      }
    }

    public static string BrightOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353292);
      }
    }

    public static string Lemon
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353307);
      }
    }

    public static string PurpleGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353322);
      }
    }

    public static string AcidGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353337);
      }
    }

    public static string PaleLavender
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353352);
      }
    }

    public static string VioletBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353367);
      }
    }

    public static string LightForestGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353382);
      }
    }

    public static string BurntRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353397);
      }
    }

    public static string KhakiGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353412);
      }
    }

    public static string Cerise
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353427);
      }
    }

    public static string FadedPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353442);
      }
    }

    public static string Apricot
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353457);
      }
    }

    public static string DarkOliveGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353472);
      }
    }

    public static string GreyBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353487);
      }
    }

    public static string GreenGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353502);
      }
    }

    public static string TrueBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353517);
      }
    }

    public static string PaleViolet
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353532);
      }
    }

    public static string PeriwinkleBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353547);
      }
    }

    public static string LightSkyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353562);
      }
    }

    public static string Blurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353577);
      }
    }

    public static string GreenBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353592);
      }
    }

    public static string Bluegreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353607);
      }
    }

    public static string BrightTeal
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353622);
      }
    }

    public static string BrownishYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353637);
      }
    }

    public static string PeaSoup
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353652);
      }
    }

    public static string Forest
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353667);
      }
    }

    public static string BarneyPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353682);
      }
    }

    public static string Ultramarine
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353697);
      }
    }

    public static string Purplish
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353712);
      }
    }

    public static string PukeYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353727);
      }
    }

    public static string BluishGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353742);
      }
    }

    public static string DarkPeriwinkle
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353757);
      }
    }

    public static string DarkLilac
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353772);
      }
    }

    public static string Reddish
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353787);
      }
    }

    public static string LightMaroon
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353802);
      }
    }

    public static string DustyPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353817);
      }
    }

    public static string TerraCotta
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353832);
      }
    }

    public static string Avocado
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353847);
      }
    }

    public static string MarineBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353862);
      }
    }

    public static string TealGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353877);
      }
    }

    public static string SlateGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353892);
      }
    }

    public static string LighterGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353907);
      }
    }

    public static string ElectricGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353922);
      }
    }

    public static string DustyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353937);
      }
    }

    public static string GoldenYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353952);
      }
    }

    public static string BrightYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353967);
      }
    }

    public static string LightLavender
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353982);
      }
    }

    public static string Umber
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a353997);
      }
    }

    public static string Poop
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354012);
      }
    }

    public static string DarkPeach
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354027);
      }
    }

    public static string JungleGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354042);
      }
    }

    public static string Eggshell
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354057);
      }
    }

    public static string Denim
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354072);
      }
    }

    public static string YellowBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354087);
      }
    }

    public static string DullPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354102);
      }
    }

    public static string ChocolateBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354117);
      }
    }

    public static string WineRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354132);
      }
    }

    public static string NeonBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354147);
      }
    }

    public static string DirtyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354162);
      }
    }

    public static string LightTan
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354177);
      }
    }

    public static string IceBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354192);
      }
    }

    public static string CadetBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354207);
      }
    }

    public static string DarkMauve
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354222);
      }
    }

    public static string VeryLightBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354237);
      }
    }

    public static string GreyPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354252);
      }
    }

    public static string PastelPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354267);
      }
    }

    public static string VeryLightGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354282);
      }
    }

    public static string DarkSkyBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354297);
      }
    }

    public static string Evergreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354312);
      }
    }

    public static string DullPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354327);
      }
    }

    public static string Aubergine
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354342);
      }
    }

    public static string Mahogany
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354357);
      }
    }

    public static string ReddishOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354372);
      }
    }

    public static string DeepGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354387);
      }
    }

    public static string VomitGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354402);
      }
    }

    public static string PurplePink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354417);
      }
    }

    public static string DustyPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354432);
      }
    }

    public static string FadedGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354447);
      }
    }

    public static string CamoGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354462);
      }
    }

    public static string PinkyPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354477);
      }
    }

    public static string PinkPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354492);
      }
    }

    public static string BrownishRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354507);
      }
    }

    public static string DarkRose
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354522);
      }
    }

    public static string Mud
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354537);
      }
    }

    public static string Brownish
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354552);
      }
    }

    public static string EmeraldGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354567);
      }
    }

    public static string PaleBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354582);
      }
    }

    public static string DullBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354597);
      }
    }

    public static string BurntUmber
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354612);
      }
    }

    public static string MediumGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354627);
      }
    }

    public static string Clay
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354642);
      }
    }

    public static string LightAqua
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354657);
      }
    }

    public static string LightOliveGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354672);
      }
    }

    public static string BrownishOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354687);
      }
    }

    public static string DarkAqua
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354702);
      }
    }

    public static string PurplishPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354717);
      }
    }

    public static string DarkSalmon
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354732);
      }
    }

    public static string GreenishGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354747);
      }
    }

    public static string Jade
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354762);
      }
    }

    public static string UglyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354777);
      }
    }

    public static string DarkBeige
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354792);
      }
    }

    public static string Emerald
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354807);
      }
    }

    public static string PaleRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354822);
      }
    }

    public static string LightMagenta
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354837);
      }
    }

    public static string Sky
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354852);
      }
    }

    public static string LightCyan
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354867);
      }
    }

    public static string YellowOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354882);
      }
    }

    public static string ReddishPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354897);
      }
    }

    public static string ReddishPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354912);
      }
    }

    public static string Orchid
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354927);
      }
    }

    public static string DirtyYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354942);
      }
    }

    public static string OrangeRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354957);
      }
    }

    public static string DeepRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354972);
      }
    }

    public static string OrangeBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a354987);
      }
    }

    public static string CobaltBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355002);
      }
    }

    public static string NeonPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355017);
      }
    }

    public static string RosePink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355032);
      }
    }

    public static string GreyishPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355047);
      }
    }

    public static string Raspberry
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355062);
      }
    }

    public static string AquaGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355077);
      }
    }

    public static string SalmonPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355092);
      }
    }

    public static string Tangerine
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355107);
      }
    }

    public static string BrownishGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355122);
      }
    }

    public static string RedBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355137);
      }
    }

    public static string GreenishBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355152);
      }
    }

    public static string Pumpkin
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355167);
      }
    }

    public static string PineGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355182);
      }
    }

    public static string Charcoal
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355197);
      }
    }

    public static string BabyPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355212);
      }
    }

    public static string Cornflower
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355227);
      }
    }

    public static string BlueViolet
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355242);
      }
    }

    public static string Chocolate
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355257);
      }
    }

    public static string GreyishGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355272);
      }
    }

    public static string Scarlet
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355287);
      }
    }

    public static string GreenYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355302);
      }
    }

    public static string DarkOlive
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355317);
      }
    }

    public static string Sienna
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355332);
      }
    }

    public static string PastelPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355347);
      }
    }

    public static string Terracotta
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355362);
      }
    }

    public static string AquaBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355377);
      }
    }

    public static string SageGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355392);
      }
    }

    public static string BloodRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355407);
      }
    }

    public static string DeepPink
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355422);
      }
    }

    public static string Grass
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355437);
      }
    }

    public static string Moss
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355452);
      }
    }

    public static string PastelBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355467);
      }
    }

    public static string BluishGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355482);
      }
    }

    public static string GreenBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355497);
      }
    }

    public static string DarkTan
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355512);
      }
    }

    public static string GreenishBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355527);
      }
    }

    public static string PaleOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355542);
      }
    }

    public static string Vomit
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355557);
      }
    }

    public static string ForrestGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355572);
      }
    }

    public static string DarkLavender
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355587);
      }
    }

    public static string DarkViolet
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355602);
      }
    }

    public static string PurpleBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355617);
      }
    }

    public static string DarkCyan
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355632);
      }
    }

    public static string OliveDrab
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355647);
      }
    }

    public static string Pinkish
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355662);
      }
    }

    public static string Cobalt
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355677);
      }
    }

    public static string NeonPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355692);
      }
    }

    public static string LightTurquoise
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355707);
      }
    }

    public static string AppleGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355722);
      }
    }

    public static string DullGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355737);
      }
    }

    public static string Wine
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355752);
      }
    }

    public static string PowderBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355767);
      }
    }

    public static string OffWhite
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355782);
      }
    }

    public static string ElectricBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355797);
      }
    }

    public static string DarkTurquoise
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355812);
      }
    }

    public static string BluePurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355827);
      }
    }

    public static string Azure
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355842);
      }
    }

    public static string BrightRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355857);
      }
    }

    public static string PinkishRed
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355872);
      }
    }

    public static string CornflowerBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355887);
      }
    }

    public static string LightOlive
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355902);
      }
    }

    public static string Grape
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355917);
      }
    }

    public static string GreyishBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355932);
      }
    }

    public static string PurplishBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355947);
      }
    }

    public static string YellowishGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355962);
      }
    }

    public static string GreenishYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355977);
      }
    }

    public static string MediumBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a355992);
      }
    }

    public static string DustyRose
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356007);
      }
    }

    public static string LightViolet
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356022);
      }
    }

    public static string MidnightBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356037);
      }
    }

    public static string BluishPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356052);
      }
    }

    public static string RedOrange
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356067);
      }
    }

    public static string DarkMagenta
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356082);
      }
    }

    public static string Greenish
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356097);
      }
    }

    public static string OceanBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356112);
      }
    }

    public static string Coral
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356127);
      }
    }

    public static string Cream
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356142);
      }
    }

    public static string ReddishBrown
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356157);
      }
    }

    public static string BurntSienna
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356172);
      }
    }

    public static string Brick
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356187);
      }
    }

    public static string Sage
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356202);
      }
    }

    public static string GreyGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356217);
      }
    }

    public static string White
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356232);
      }
    }

    public static string RobinSEggBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356247);
      }
    }

    public static string MossGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356262);
      }
    }

    public static string SteelBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356277);
      }
    }

    public static string Eggplant
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356292);
      }
    }

    public static string LightYellow
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356307);
      }
    }

    public static string LeafGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356322);
      }
    }

    public static string LightGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356337);
      }
    }

    public static string Puke
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356352);
      }
    }

    public static string PinkishPurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356367);
      }
    }

    public static string SeaBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356382);
      }
    }

    public static string PalePurple
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356397);
      }
    }

    public static string SlateBlue
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356412);
      }
    }

    public static string BlueGrey
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356427);
      }
    }

    public static string HunterGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.a356442);
      }
    }
      */
    public static string Fuchsia
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Fuchsia);
      }
    }

    public static string Crimson
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Crimson);
      }
    }

    public static string PaleYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PaleYellow);
      }
    }

    public static string Ochre
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Ochre);
      }
    }

    public static string MustardYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.MustardYellow);
      }
    }

    public static string LightRed
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightRed);
      }
    }

    public static string Cerulean
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Cerulean);
      }
    }

    public static string PalePink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PalePink);
      }
    }

    public static string DeepBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DeepBlue);
      }
    }

    public static string Rust
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Rust);
      }
    }

    public static string LightTeal
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightTeal);
      }
    }

    public static string Slate
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Slate);
      }
    }

    public static string Goldenrod
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Goldenrod);
      }
    }

    public static string DarkYellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkYellow);
      }
    }

    public static string DarkGrey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkGrey);
      }
    }

    public static string ArmyGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.ArmyGreen);
      }
    }

    public static string GreyBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GreyBlue);
      }
    }

    public static string Seafoam
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Seafoam);
      }
    }

    public static string Puce
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Puce);
      }
    }

    public static string SpringGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SpringGreen);
      }
    }

    public static string DarkOrange
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkOrange);
      }
    }

    public static string Sand
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Sand);
      }
    }

    public static string PastelGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PastelGreen);
      }
    }

    public static string Mint
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Mint);
      }
    }

    public static string LightOrange
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightOrange);
      }
    }

    public static string BrightPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BrightPink);
      }
    }

    public static string Chartreuse
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Chartreuse);
      }
    }

    public static string DeepPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DeepPurple);
      }
    }

    public static string DarkBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkBrown);
      }
    }

    public static string Taupe
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Taupe);
      }
    }

    public static string PeaGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PeaGreen);
      }
    }

    public static string PukeGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PukeGreen);
      }
    }

    public static string KellyGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.KellyGreen);
      }
    }

    public static string SeafoamGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SeafoamGreen);
      }
    }

    public static string BlueGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BlueGreen);
      }
    }

    public static string Khaki
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Khaki);
      }
    }

    public static string Burgundy
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Burgundy);
      }
    }

    public static string DarkTeal
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkTeal);
      }
    }

    public static string BrickRed
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BrickRed);
      }
    }

    public static string RoyalPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RoyalPurple);
      }
    }

    public static string Plum
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Plum);
      }
    }

    public static string MintGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.MintGreen);
      }
    }

    public static string Gold
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Gold);
      }
    }

    public static string BabyBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BabyBlue);
      }
    }

    public static string YellowGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.YellowGreen);
      }
    }

    public static string BrightPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BrightPurple);
      }
    }

    public static string DarkRed
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkRed);
      }
    }

    public static string PaleBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PaleBlue);
      }
    }

    public static string GrassGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.GrassGreen);
      }
    }

    public static string Navy
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Navy);
      }
    }

    public static string Aquamarine
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Aquamarine);
      }
    }

    public static string BurntOrange
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BurntOrange);
      }
    }

    public static string NeonGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.NeonGreen);
      }
    }

    public static string BrightBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BrightBlue);
      }
    }

    public static string Rose
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Rose);
      }
    }

    public static string LightPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightPink);
      }
    }

    public static string Mustard
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Mustard);
      }
    }

    public static string Indigo
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Indigo);
      }
    }

    public static string Lime
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Lime);
      }
    }

    public static string SeaGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SeaGreen);
      }
    }

    public static string Periwinkle
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Periwinkle);
      }
    }

    public static string DarkPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkPink);
      }
    }

    public static string OliveGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.OliveGreen);
      }
    }

    public static string Peach
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Peach);
      }
    }

    public static string PaleGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.PaleGreen);
      }
    }

    public static string LightBrown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightBrown);
      }
    }

    public static string HotPink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.HotPink);
      }
    }

    public static string Black
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Black);
      }
    }

    public static string Lilac
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Lilac);
      }
    }

    public static string NavyBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.NavyBlue);
      }
    }

    public static string RoyalBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.RoyalBlue);
      }
    }

    public static string Beige
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Beige);
      }
    }

    public static string Salmon
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Salmon);
      }
    }

    public static string Olive
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Olive);
      }
    }

    public static string Maroon
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Maroon);
      }
    }

    public static string BrightGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.BrightGreen);
      }
    }

    public static string DarkPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkPurple);
      }
    }

    public static string Mauve
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Mauve);
      }
    }

    public static string ForestGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.ForestGreen);
      }
    }

    public static string Aqua
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Aqua);
      }
    }

    public static string Cyan
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Cyan);
      }
    }

    public static string Tan
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Tan);
      }
    }

    public static string DarkBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkBlue);
      }
    }

    public static string Lavender
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Lavender);
      }
    }

    public static string Turquoise
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Turquoise);
      }
    }

    public static string DarkGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.DarkGreen);
      }
    }

    public static string Violet
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Violet);
      }
    }

    public static string LightPurple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightPurple);
      }
    }

    public static string LimeGreen
    {
      get
      {
        return ColorTranslator.ToHex(XKCDColors.LimeGreen);
      }
    }

    public static string Grey
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Grey);
      }
    }

    public static string SkyBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.SkyBlue);
      }
    }

    public static string Yellow
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Yellow);
      }
    }

    public static string Magenta
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Magenta);
      }
    }

    public static string LightGreen
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightGreen);
      }
    }

    public static string Orange
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Orange);
      }
    }

    public static string Teal
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Teal);
      }
    }

    public static string LightBlue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.LightBlue);
      }
    }

    public static string Red
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Red);
      }
    }

    public static string Brown
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Brown);
      }
    }

    public static string Pink
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Pink);
      }
    }

    public static string Blue
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Blue);
      }
    }

    public static string Green
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Green);
      }
    }

    public static string Purple
    {
      get
      {
          return ColorTranslator.ToHex(XKCDColors.Purple);
      }
    }
  }
}

}
