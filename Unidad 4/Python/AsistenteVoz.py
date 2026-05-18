from gtts import gTTS
import pygame
from datetime import datetime

texto = "En el año 2478, la humanidad vive dispersa en colonias espaciales dominadas por corporaciones. Kael Virex, un piloto con pasado militar, recorre el espacio aceptando misiones tras perder a su familia en la destrucción de Helios-9.Todo cambia cuando recibe una señal desde el sector prohibido Orpheus. El mensaje menciona el Núcleo Eón, un artefacto capaz de alterar el espacio-tiempo. Varias facciones lo buscan: la poderosa Corporación Zenith, los rebeldes de Nova Terra y una misteriosa entidad desconocida. Al llegar, Kael encuentra sistemas abandonados, naves destruidas y anomalías que afectan su mente y su nave. Durante una misión rescata a Lyra Solen, una científica que revela que el Núcleo podría estar vivo y corrompe todo a su alrededor.Mientras mejora su nave y enfrenta combates espaciales, Kael deberá decidir si ayudar a Zenith, unirse a los rebeldes o descubrir la verdad. Pero el Núcleo comienza a comunicarse con él, mostrándole visiones inquietantes"

tts= gTTS(text=texto,lang="es",tld="com.mx")
nombre = "audio"+ str(datetime.now().second)+".mp3"
tts.save(nombre)
pygame.mixer.init()
pygame.mixer.music.load("C://Users/oscar/Dropbox/UNIVERSIDAD/Cuarto semestre/Administracion de datos/Tercer Parcial/Unidad 4/"+nombre)
pygame.mixer.music.play()
while pygame.mixer.music.get_busy():
    continue