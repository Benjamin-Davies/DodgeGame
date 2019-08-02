<?php
require_once('./includes/connect.php');

switch ($_SERVER['REQUEST_METHOD']) {
case 'GET':
  $query = $pdo->prepare('SELECT Username, LifeCount, Score FROM scoreboard ORDER BY Score DESC LIMIT 100');
  $query->execute();
  $scores = $query->fetchAll(PDO::FETCH_ASSOC);

  header('Content-Type: application/json');

  echo json_encode($scores);
  break;
case 'POST':
  $query = $pdo->prepare('
    INSERT INTO scoreboard (Username, LifeCount, Score)
    VALUES (:Username, :LifeCount, :Score)');
  $query->bindValue('Username', $_POST['Username']);
  $query->bindValue('LifeCount', $_POST['LifeCount']);
  $query->bindValue('Score', $_POST['Score']);
  $query->execute();
  break;
}
?>
