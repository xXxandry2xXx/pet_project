# ���������� ����������� ����� Node.js 20 � �������� ��������
FROM node:20 AS build

# ������������� ������� ���������� ������ ����������
WORKDIR /app

# �������� ����� package.json � package-lock.json (���� ����) � ���������
COPY package*.json ./

# ������������� ����������� �������
RUN npm install -g patch-package
RUN npm install vue3-touch-events
RUN npm install

# �������� ��������� ����� ������� � ���������
COPY . .

# ��������� ������ �������
RUN npm run build-only

FROM nginx:1.16.0-alpine
COPY --from=build /app/dist /usr/share/nginx/html
RUN rm /etc/nginx/conf.d/default.conf
COPY nginx.conf /etc/nginx/conf.d
EXPOSE 80

# ��������� Nginx
CMD ["nginx", "-g", "daemon off;"]