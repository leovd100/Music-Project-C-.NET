<h1>Music Project</h1>

<h3>Esse projeto tem como objetivo criar um game que funcione a partir da música em tempo real.</h3>

####----------------------------------------

O game utiliza as batidas da música para setar objetos em cena.

	Uma musica é formada por várias batidas. Quando está em um gráfico, estas batidas se tornam senóides. 
	
	Joseph Fourier, em 1768 descobriu que o calor gerava ondas e apartir dai criou uma formula para achar estas ondas. Hoje ela é 	usada para achar o comprimento de ondas músicais. 

Linguagens e tecnologias:

	UNITY5
	Linguagem : C#
	.NET MONO - MonoDeveloper

![Mplayer](https://i.imgur.com/HxlHOBa.png "Mplayer")

Codigo em C# para Unity 
	
	Ele é um pouco diferente do C# normal, sim houve muitas mudanças no C# da microsoft, entretanto as bibliotecas são puxadas do    Visual Studio. 
	
![Codigo](https://i.imgur.com/Pv1YF60.png "Codigo")
	
	
O AudioListener.GetSpectrumData pega as batidas da música e a partir delas ele vai instânciar um objeto que pode ser o obstáculo do player ou um efeito luminoso. 
