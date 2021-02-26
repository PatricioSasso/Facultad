import pygame, random
from pygame.locals import *

class Graficos(object):

   CELESTE = (160 , 180, 255)
   AZULOSCURO = (0, 0, 20)
   NEGRO = (0, 0, 0)
   tamañoPantalla = [1300, 650]

   @classmethod
   def GraficarBarras(self, diccionario, titulo):
       pantalla = pygame.display.set_mode(self.tamañoPantalla)
       pygame.display.set_caption(titulo)
       cerrar = False
       pygame.init()

       while cerrar == False:
            pantalla.fill(self.CELESTE)
            fontTitulo=pygame.font.Font(None,50)
            fontTitulo.set_underline(True)
            texto = fontTitulo.render(titulo, 1 , self.NEGRO)
            pantalla.blit( texto, (270, 10) )
            max = 0
            for v in diccionario.values():
                if( v > max):
                    max = v
            x = 20; y = 100
            ancho = 100; maxAltura = 500
            if(self.tamañoPantalla[0] < (x + (ancho * len(diccionario))) ):
                ancho = self.tamañoPantalla[0] / len(diccionario)
            fontTexto=pygame.font.Font(None,30) 
            for key,valor in diccionario.items():
                altura = 0
                if(valor == max):
                    re = Rect( x, y, ancho, maxAltura )
                else:
                    altura = (valor * maxAltura) / max
                    re = Rect(x, (y + maxAltura - altura) ,ancho,altura)
                texto = fontTexto.render(key, 1 , self.NEGRO)
                pantalla.blit( texto, (x, (y + maxAltura)) )
                texto = fontTexto.render("$ "+str(valor) , 1 , self.NEGRO)
                pantalla.blit(texto,(x, y + maxAltura + 20))
                pygame.draw.rect(pantalla, self.AZULOSCURO, re)
                x += ancho + 20

            pygame.display.update()
            for eventos in pygame.event.get():
                if eventos.type == pygame.QUIT:
                    cerrar = True
                    pygame.quit()