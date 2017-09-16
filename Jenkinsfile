node{
	
	currentBuild.result="SUCCESS"
	
	environment {
         PIPELINE_VERSION = VersionNumber(versionNumberString: '0.0.0.${BUILD_DATE_FORMATTED,\"yy\"}${BUILD_MONTH, XX}.${BUILDS_THIS_MONTH}')
    }
	
	try {
	
		timestamps {
			stage('Build') {
			
				currentBuild.displayName = env.PIPELINE_VERSION
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
					step([$class: 'XUnitPublisher', testTimeMargin: '3000', thresholdMode: 1, thresholds: [[$class: 'FailedThreshold', failureNewThreshold: '', failureThreshold: '', unstableNewThreshold: '', unstableThreshold: ''], [$class: 'SkippedThreshold', failureNewThreshold: '', failureThreshold: '', unstableNewThreshold: '', unstableThreshold: '']], tools: [[$class: 'MSTestJunitHudsonTestType', deleteOutputFiles: true, failIfNotNew: true, pattern: '**/test/unit/**/*.trx', skipNoTestFiles: false, stopProcessingIfError: true]]])
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
					step([$class: 'XUnitPublisher', testTimeMargin: '3000', thresholdMode: 1, thresholds: [[$class: 'FailedThreshold', failureNewThreshold: '', failureThreshold: '', unstableNewThreshold: '', unstableThreshold: ''], [$class: 'SkippedThreshold', failureNewThreshold: '', failureThreshold: '', unstableNewThreshold: '', unstableThreshold: '']], tools: [[$class: 'MSTestJunitHudsonTestType', deleteOutputFiles: true, failIfNotNew: true, pattern: '**/test/unit/**/*.trx', skipNoTestFiles: false, stopProcessingIfError: true]]])
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