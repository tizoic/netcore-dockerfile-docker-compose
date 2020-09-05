# netcore-dockerfile-docker-compose
API REST with .net core 3.1, , dockerfile and docker-compose

# Pre Requisite
# Disable swap memory

$ sudo swapoff -a

$ sudo nano /etc/fstab (Comment swap line / reboot)


# Uninstall old versions docker
$ sudo apt-get remove docker docker-engine docker.io containerd runc

# Install Docker
$ sudo apt-get update

$ sudo apt-get install \
    apt-transport-https \
    ca-certificates \
    curl \
    gnupg-agent \
    software-properties-common

$ curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -

$ sudo add-apt-repository \
   "deb [arch=amd64] https://download.docker.com/linux/ubuntu \
   $(lsb_release -cs) \
   stable"

$ sudo apt-get update

$ sudo apt-get install docker-ce docker-ce-cli containerd.io

$ sudo usermod -aG docker your-user

# Install Docker-Compose

$ sudo curl -L "https://github.com/docker/compose/releases/download/1.25.5/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose

$ sudo chmod +x /usr/local/bin/docker-compose

$ sudo ln -s /usr/local/bin/docker-compose /usr/bin/docker-compose

# Create Docker image
$ cd src/
$ docker build -t backend:1.0.0-staging .

# Docker-Compose Run
$ docker-compose up

# Go to
http://localhost:3000/swagger
