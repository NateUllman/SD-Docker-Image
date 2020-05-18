#!/usr/bin/env sh

set -ex
source ci/set_registry_variables.sh

docker build -f ./docker/ubuntu_prepare.Dockerfile $IMAGE_LABELS --label build-date=`date -Iseconds` $IMAGE_ARGUMENTS --pull -t "$REGISTRY" ./docker/
docker push "$REGISTRY"

docker run "$REGISTRY" cat Unity_v$VERSION$BUILD.alf >> licence_request.alf
