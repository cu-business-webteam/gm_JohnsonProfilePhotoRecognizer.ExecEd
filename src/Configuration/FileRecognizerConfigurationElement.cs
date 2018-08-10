using System.Linq;

namespace Johnson.ProfilePhotoRecognizer.ExecEd.Configuration {

	[System.Serializable]
	public sealed class FileRecognizerConfigurationElement : System.Configuration.ConfigurationElement {

		#region .ctor
		public FileRecognizerConfigurationElement() : base() {
		}
		#endregion .ctor


		#region properties
		[System.IO.IODescription( "The regular expression which identifies the file." )]
		[System.Configuration.ConfigurationProperty( "regexMask", IsRequired = true, IsKey = false )]
		public System.String RegexMask {
			get {
				return ( this[ "regexMask" ] as System.String).TrimToNull();
			}
			set {
				this[ "regexMask" ] = value.TrimToNull();
			}
		}
		[System.IO.IODescription( "The name of the capture group containing the SalesForce ID." )]
		[System.Configuration.ConfigurationProperty( "sfIdCaptureName", IsRequired = true, IsKey = false )]
		public System.String SfIdCaptureName {
			get {
				return ( this[ "sfIdCaptureName" ] as System.String ).TrimToNull();
			}
			set {
				this[ "sfIdCaptureName" ] = value.TrimToNull();
			}
		}
		[System.IO.IODescription( "The directory to where the file should be moved." )]
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