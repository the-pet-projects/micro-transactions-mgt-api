node{
	
	currentBuild.result="SUCCESS"
	
		
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
}