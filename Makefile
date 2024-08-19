CLUSTER_NAME := k8s-cluster-local
HELM_CHART_NAME := purchase-api
HELM_CHART_VERSION := 1.0.0
NAMESPACE := default
REPO_URL := https://github.com/joaopaulopmedeiros/giti-k8s-iac.git

create-cluster:
	kind create cluster --name $(CLUSTER_NAME)

install-argocd:
	kubectl create namespace argocd
	kubectl apply -n argocd -f https://raw.githubusercontent.com/argoproj/argo-cd/stable/manifests/install.yaml

expose-argocd:
	kubectl port-forward svc/argocd-server -n argocd 8080:443

add-helm-chart:
	argocd repo add $(REPO_URL) --type git --name purchase-api --upsert

delete-cluster:
	kind delete cluster --name $(CLUSTER_NAME)

forward-purchase-api:
	kubectl port-forward svc/purchase-api 5121:5121	

all: create-cluster install-argocd expose-argocd add-helm-chart
