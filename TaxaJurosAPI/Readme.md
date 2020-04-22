# Taxa De Juros

Esta API fornece um único endpoint:

 - /taxajuros
	 - Retorna o valor fixo de `0.01` as chamadas GET.


Para mais detalhes dessa API: [Swagger](https://app.swaggerhub.com/apis-docs/lucas.fernando.martioli/TaxaJuros/1.0.0)

# Deploy no Docker

Basta fazer o build da imagem na pasta do projeto:

    docker build .

Criar o container usando a imagem gerada, como por exemplo:

    docker run -it -p 5000:80 -p 5001:443 --name TaxaJuros <image name>

> As **portas** definidas são apenas exemplos e estão fixas no comando do docker pois **são as mesmas expostas** no **Dockerfile**