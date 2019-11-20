#!/usr/bin/env python3
import alsaaudio
import socket
import threading

PORT = 5055
DEBUG = False

def net_client_thread(socket):
    request = socket.recv(1024)
    request = request.decode('utf-8')
    token = request.split(';')
    cmd = token[0]
    if cmd == 'VOL':
        mixer = alsaaudio.Mixer('Digital')
        mixer.setvolume(int(token[1]))
        newvol = mixer.getvolume()
        if DEBUG:
            print(f'Volume is now: {newvol}')
        socket.send(bytearray(f'OK;{newvol[0]}','utf-8'))
    elif cmd == 'CHKVOL':
        mixer = alsaaudio.Mixer('Digital')
        vol = mixer.getvolume()
        if DEBUG:
            print(f'Volume checked! ({vol})')
        socket.send(bytearray(f'OK;{vol[0]}','utf-8'))
    else:
        socket.send(bytearray('ERR','utf-8'))
    socket.close()

def main():
    server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server.bind(('0.0.0.0',5055))
    server.listen(5)
    print(f"Listening on port: {PORT}")
    while True:
        cl_socket, addr = server.accept()
        if DEBUG:
            print(f"Accepted connection from {addr[0]}:{addr[1]}")
        handler = threading.Thread(
                target = net_client_thread,
                args = (cl_socket,)
        )
        handler.start()

main()

#
#
#
#
