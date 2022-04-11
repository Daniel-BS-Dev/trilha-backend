# O que é HTTP
 É um protocolo de comunicação entre sistemas de informação que permite a transferência de dados entre redes de computadores, principalmente na World Wide Web (Internet).

# HTTPS

O HTTPS não guarda estado cada requisição ela é unica no mundo web, sendo assim através do login a minha requisição manda uma mensagem para o navegador para ele guardar minhas informações a tecnologia de sessão só é possivel por que no navegador guarda cookies

# HTTP (REQUEST-RESPONSE)
- O protocolo HTTP segue o modelo REQUISIÇÃO-RESPOSTA
- Uma requisição precisa ter todas as informações para o servidor gerar a resposta
- HTTP é STATLESS!(Não matém informações entre requisições, não guarda estado)
- As plataformas de desenvolvimento usam sessões para guardar informações entre requisições

# O que é uma sessão HTTP

Uma sessão HTTP nada mais é que um tempo que o cliente permanece ativo no sistema! Isso é parecido com uma sessão no cinema. Uma sessão, nesse contexto, é o tempo que o cliente usa a sala no cinema para assistir a um filme. Quando você sai da sala, termina a sessão. Ou seja, quando você se desloga, a Alura termina a sua sessão.

# Segurança HTTPS

No certificado, vem a chave pública para o cliente utilizar, certo? E o servidor continua na posse da chave privada, ok? Isso é seguro, mas lento e por isso o cliente gera uma chave simétrica ao vivo. Uma chave só para ele e o servidor com o qual está se comunicando naquele momento! Essa chave exclusiva (e simétrica) é então enviada para o servidor utilizando a criptografia assimétrica (chave privada e pública) e então é utilizada para o restante da comunicação.

Então, HTTPS começa com criptografia assimétrica para depois mudar para criptografia simétrica. Essa chave simétrica será gerada no início da comunicação e será reaproveitada nas requisições seguintes. Bem-vindo ao mundo fantástico do HTTPS :)

# Servidor DNS

Domani Name System resolve para me o nome de uma dominio e devolve um endereço IP 

# Definição de Endereço IP

### HTTPS://www.alura.com.br:443/course/introducao-HTML-CSS

- HTTPS: protocolo
- www.alura.com.br: domínio
- com: site comecial ou governamental
- br: especifico para um determinado pais 
- 443: porta não obrigatorio informar
- course/introducao-HTML-CSS: area especifca de um evento

# URL, URI e URN

### URI
As URIs são o padrão para identificação de documentos com uma curta sequência de números, letras e símbolos. O termo significa no Inglês Uniform Resource Identifier (URI) – Identificador de Recurso Uniforme.

### URL
URLs também seguem uma nomenclatura similar. Significa Uniform Resource Locator – Localizador de Recurso Uniforme. Nesses endereços contém informações sobre como buscar um recurso em sua localização.

Quando falamos de recursos a serem buscados podem ser tanto websites completos (igual esse que você está acessando agora) quanto outros tipos de dados que são transmitidos via web em outros formatos e por meio de outros protocolos que não HTTP ou HTTPS.

Exemplo:

- http://website.com/pagina.html
- ftp://website.com.br/download.zip
- mailto:contato@website.com.br
- file:///home/usuario/arquivo.txt
- tel:+5511123456789

### URN
URN então, seguindo o mesmo padrão dos dois anteriores, significa Uniform Resource Name – Nome de Recurso Uniforme. Ele identifica um recurso na web através de um nome único e persistente, mas não necessariamente ele informa onde o localizar na internet. Normalmente começa com o prefixo urn:.

Por exemplo:

- urn:isbn:042424553 para identificar um livro através de seu número ISBN
- urn:uuid:6e8bc430-9c3a-11d9-9669-0800200c9a66 como un identificador global único
- urn:publishing:book como um XML que identifica um documento como um tipo de livro
- URNs podem identificar ideias e conceitos. Eles não estão restritos a documentos, mas quando eles representam documentos podem ser convertidos a URLs por um “resolver”. A partir daí o documento pode ser baixado através de uma URL.


# STATUS CODE 

- 2XX - Successful response
- 3XX - Redirection messages
- 4xx - Client error responses
- 5xx - Server error responses

- 200 OK
- 301 Moved Permanently
- 404 Not Found
- 500 Internal Server Error

# CAMINHO COM MAIS PARAMETROS

HTTPS://LOCALHOST?RESULTS=CARRO&COLOR=BLACK

# METHODS

- GET - Receber dados (params na URL)
- POST - Submeter dados(params no corpr da requisição)
- DELETE - Remover um recurso
- PUT - Atualizar

# HPACK

O HPACK é uma tecnologia especializada em comprimir os Headers das comunicações HTTP/2. Como toda requisição HTTP acompanha algum header por padrão, uma tecnologia de compressão embutida no protocolo é demasiadamente útil para economizar dados trafegados. Guarda os dados
Quando estamos utilizando Headers Stateful, simplesmente colocamos nas requisições os cabeçalhos que se alteraram entre uma e outra, trazendo uma enorme economia de dados, visto que toda requisição HTTP possui um cabeçalho e que, muitas vezes, no HTTP/1.1, cabeçalhos repetidos eram trafegados em todas as requisições.
