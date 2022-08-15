# 3. Fluxo de desenvolvimento remoto

### 3.1. Criar uma cópia do localmente
```
git clone "link do repositório"
```
### 3.2. Definir qual o endereço do repositório remoto receberá o código-fonte do repositório local
```
git remote add origin "link do repositório"
```

### 3.3. Enviar o código-fonte do governo local para o remoto
```
git branch -M main
git push -u origin main
```

### 3.4. Verificar e baixar configurações no fonte do remoto para o código local
```
git pull
