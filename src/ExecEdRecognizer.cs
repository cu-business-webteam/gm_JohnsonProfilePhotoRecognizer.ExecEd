namespace Johnson.ProfilePhotoRecognizer.ExecEd {

	public sealed class ExecEdRecognizer : IFileRecognizer {

		public ExecEdRecognizer() : base() {
		}


		public System.String IsRecognized( System.String fileSpecification ) {
			fileSpecification = fileSpecification.TrimToNull();
			if ( System.String.IsNullOrEmpty( fileSpecification ) ) {
				throw new System.ArgumentNullException( "fileSpecification" );
			}

			var fileName = System.IO.Path.GetFileName( fileSpecification );
			var fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension( fileName );

			var dllConfig = System.Configuration.ConfigurationManager.OpenExeConfiguration( System.Reflection.Assembly.GetExecutingAssembly().Location );
			var settings = dllConfig.AppSettings;
			var regExp = settings.Settings[ "fileNameWithoutExtension" ].Value.TrimToNull();
			if ( System.String.IsNullOrEmpty( regExp ) ) {
				throw new System.Configuration.ConfigurationErrorsException( "fileNameWithoutExtension appSetting is not configured." );
			}
			return ( System.Text.RegularExpressions.Regex.IsMatch( fileNameWithoutExtension, regExp, System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Singleline ) )
				? System.IO.Path.Combine(
					settings.Settings[ "destination" ].Value.TrimToNull(),
					System.Text.RegularExpressions.Regex.Match( fileNameWithoutExtension, regExp ).Groups[ "sfId" ].Value + System.IO.Path.GetExtension( fileName )
				)
				: null
			;

			throw new System.NotImplementedException();
		}

	}

}