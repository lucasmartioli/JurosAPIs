# Calculadora De Juros

Esta API fornece dois endpoints:

 - /calculajuros
	 - Espera dois paramentos na URL GET `valorinicial` e `tempo`.
	 - Retorna o valor final, ou seja, `valorinicial` acrescido dos juros no `tempo`
 - /showmethecode


Para mais detalhes dessa API: [Swagger](https://app.swaggerhub.com/apis-docs/lucas.fernando.martioli/CalculadoraJuros/1.0.0)

# Deploy no Docker

Basta fazer o build da imagem na pasta do projeto:

    docker build .

Criar o container usando a imagem gerada, como por exemplo:

    docker run -it -p 5002:80 -p 5003:443 --env TAXAJUROSAPI_BASEURL=http://192.168.99.100:5000 --name CalculadoraJuros <image name>

Para o correto funcionamento desta API é necessário adicionar a variável de ambiente que endereça a API de Taxa de Juros: 

    TAXAJUROSAPI_BASEURL

 Por exemplo:

    "TAXAJUROSAPI_BASEURL": "http://192.168.99.100:5000"

> As **portas** definidas são apenas exemplos e estão fixas no comando do docker pois **são as mesmas expostas** no **Dockerfile**