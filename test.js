Jenkinsfile (Declarative Pipeline)
pipeline {
    agent { docker 'node:6.3' }
    stages {
        stage('build') {
            steps {
                sh 'npm --version'
            }
        }
    }
}

//test
//test1
//test2
//test3
//test4



