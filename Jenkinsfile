node{
	
	currentBuild.result="SUCCESS"
	
	try {
	
		def version = VersionNumber(versionNumberString: '0.0.0.${BUILD_DATE_FORMATTED,\"yy\"}${BUILD_MONTH, XX}.${BUILDS_THIS_MONTH}')
		withEnv(['PIPELINE_VERSION='+version])
		
		timestamps {
			stage('Build') {
			
				currentBuild.displayName = '#'+env.PIPELINE_VERSION
				checkout scm
				
				echo 'Building nothing with version {env.PIPELINE_VERSION}...'
			}
			
			stage('Unit Tests'){
				echo 'Unit Testing Nothing...'
			}
			
			stage('Integration Tests'){
				echo 'Integration Testing Nothing...'
			}
			
			stage('Deploy'){
				echo 'Deploy stuff which is nothing again...'
			}
		}
	}catch (err) {
		currentBuild.result="FAILURE"
			cleanWs()
		throw err
	}
}