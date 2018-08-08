using System.Linq;

namespace Johnson.ProfilePhotoRecognizer.ExecEd.Configuration {

	[System.Serializable]
	public sealed class FileRecognizerConfigurationElement : System.Configuration.ConfigurationElement {

		#region .ctor
		public FileRecognizerConfigurationElement() : base() {
		}
		#endregion .ctor


		#region properties
		[System.Configuration.ConfigurationProperty( "regexMask", IsRequired = true, IsKey = false )]
		public System.String RegexMask {
			get {
				return ( this[ "regexMask" ] as System.String).TrimToNull();
			}
			set {
				this[ "regexMask" ] = value.TrimToNull();
			}
		}
		[System.Configuration.ConfigurationProperty( "sfIdCaptureName", IsRequired = true, IsKey = false )]
		public System.String SfIdCaptureName {
			get {
				return ( this[ "sfIdCaptureName" ] as System.String ).TrimToNull();
			}
			set {
				this[ "sfIdCaptureName" ] = value.TrimToNull();
			}
		}
		[System.Configuration.ConfigurationProperty( "destination", IsRequired = true, IsKey = false )]
		public System.String Destination {
			get {
				return ( this[ "destination" ] as System.String ).TrimToNull();
			}
			set {
				this[ "destination" ] = value.TrimToNull();
			}
		}
		#endregion properties

	}

}