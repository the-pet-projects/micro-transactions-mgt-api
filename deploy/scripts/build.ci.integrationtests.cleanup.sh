docker-compose -f docker-compose.integrationtests.yml -p netcoreintegrationtests rm -fsv
docker image rm -f petprojects/micro-transactions-mgt:${BUILD_VERSION}
