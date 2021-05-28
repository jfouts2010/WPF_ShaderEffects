//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;


namespace ANEffectsLibrary
{
	
	/// <summary>Pixel shader that samples the color from an image and draws every odd pixel transparent.</summary>
	public class Crt_tvEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(Crt_tvEffect), 0);
		public static readonly DependencyProperty TextureSizeProperty = DependencyProperty.Register("TextureSize", typeof(Point), typeof(Crt_tvEffect), new UIPropertyMetadata(new Point(512D, 512D), PixelShaderConstantCallback(0)));
		public Crt_tvEffect() {
			PixelShader pixelShader = new PixelShader();
			pixelShader.UriSource = Global.MakePackUri("Effects/Shaders/Crt_tvEffect.ps");
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(TextureSizeProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		/// <summary>The Size of the texture.</summary>
		public Point TextureSize {
			get {
				return ((Point)(this.GetValue(TextureSizeProperty)));
			}
			set {
				this.SetValue(TextureSizeProperty, value);
			}
		}
		
	}
}