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
			var section = Configuration.FileRecognizerConfigurationSection.GetSection();
			var element = section.Recognizer;
			var regExp = element.RegexMask;
			var sfIdCap = element.SfIdCaptureName;
			var destination = element.Destination;

			return ( System.Text.RegularExpressions.Regex.IsMatch( fileNameWithoutExtension, regExp, System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Singleline ) )
				? System.IO.Path.Combine(
					destination,
					System.Text.RegularExpressions.Regex.Match( fileNameWithoutExtension, regExp ).Groups[ sfIdCap ].Value + System.IO.Path.GetExtension( fileName )
				)
				: null
			;

			throw new System.NotImplementedException();
		}

	}

}