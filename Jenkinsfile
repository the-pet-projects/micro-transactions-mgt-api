node{
	
	currentBuild.result="SUCCESS"
	
	try {
	
		def version = VersionNumber(versionNumberString: '0.0.0.${BUILD_DATE_FORMATTED,\"yy\"}${BUILD_MONTH, XX}.${BUILDS_THIS_MONTH}')
		withEnv(['PIPELINE_VERSION='+version])
		
		timestamps {
			stage('Build') {
			
				currentBuild.displayName = '#'+env.PIPELINE_VERSION
				deleteDir()
				checkout scm
				
				echo 'Building nothing...'
		
				/*
				try {
					sh '''./deploy/scripts/build.ci.sh'''
				}
				finally {
					sh '''./deploy/scripts/build.ci.cleanup.sh'''
				}
				*/
			}
			
			stage('Unit Tests'){
				echo 'Unit Testing Nothing...'
				/*
				try{
					sh '''./deploy/scripts/build.ci.unittests.sh'''
					step([$class: 'MSTestPublisher', testResultsFile: '**/test/unit/**/*.trx', failOnError: true, keepLongStdio: true])
					
					
				}			
				finally {
					sh '''./deploy/scripts/build.ci.unittests.cleanup.sh'''
				} 
				*/
			}
			
			stage('Integration Tests'){
				echo 'Integration Testing Nothing...'
				/*
				try{
					sh '''./deploy/scripts/build.ci.integrationtests.sh'''
					step([$class: 'MSTestPublisher', testResultsFile: '**/test/unit/**/*.trx', failOnError: true, keepLongStdio: true])
				}
				finally {
					sh '''./deploy/scripts/build.ci.integrationtests.cleanup.sh'''
				}
				*/
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